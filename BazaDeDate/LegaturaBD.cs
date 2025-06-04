using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace ProiectPAW.BazaDeDate
{
    public static class LegaturaBD
    {
        private const string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\S4\\Documents\\productie.accdb";

        public static void IncarcaMateriiSiProduse()
        {
            var dm = DataManager.Instance;

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();

                OleDbCommand cmdMaterii = new OleDbCommand("SELECT * FROM MateriePrima", con);
                OleDbDataReader readerMaterii = cmdMaterii.ExecuteReader();
                while (readerMaterii.Read())
                {
                    int id = Convert.ToInt32(readerMaterii["IdMateriePrima"]);
                    string nume = readerMaterii["Nume"].ToString();
                    string um = readerMaterii["UnitateDeMasura"].ToString();
                    double cost = Convert.ToDouble(readerMaterii["Cost"]);
                    string tip = readerMaterii["Tip"].ToString();

                    Materieprima materie = null;

                    if (tip == "Lichida")
                    {
                        double vascozitate = Convert.ToDouble(readerMaterii["Vascozitate"]);
                        materie = new MateriePrimaLichida(nume, um, cost, vascozitate);
                    }
                    else if (tip == "Solida")
                    {
                        double densitate = Convert.ToDouble(readerMaterii["Densitate"]);
                        materie = new MateriePrimaSolida(nume, um, cost, densitate);
                    }

                    if (materie != null)
                    {
                        materie.IDMateriePrima = id;
                        if (!DataManager.HashMateriiPrime.ContainsKey(materie.nume))
                            dm.AdaugaMateriePrima(materie);
                    }
                }
                readerMaterii.Close();

                OleDbCommand cmdProduse = new OleDbCommand("SELECT * FROM Produs", con);
                OleDbDataReader readerProduse = cmdProduse.ExecuteReader();

                while (readerProduse.Read())
                {
                    try
                    {
                        if (readerProduse["CodProdus"] == DBNull.Value)
                            throw new Exception("CodProdus este NULL în baza de date.");

                        int cod = Convert.ToInt32(readerProduse["CodProdus"]);

                        string numeProdus = readerProduse["NumeProdus"].ToString();
                        double pret = readerProduse["Pret"] != DBNull.Value ? Convert.ToDouble(readerProduse["Pret"]) : 0;
                        double cantitate = readerProduse["Cantitate"] != DBNull.Value ? Convert.ToDouble(readerProduse["Cantitate"]) : 0;

                        DateTime dataProductie;
                        if (readerProduse["DataProductie"] == DBNull.Value)
                            dataProductie = DateTime.Now;
                        else
                            dataProductie = Convert.ToDateTime(readerProduse["DataProductie"]);

                        var produs = new Produs
                        {
                            CodProdus = cod,
                            NumeProdus = numeProdus,
                            Pret = pret,
                            Cant = cantitate,
                            DataProductie = dataProductie,
                            ingrediente = new List<IngredientProdus>()
                        };

                        dm.AdaugaProdus(produs);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la încărcare produs: " + ex.Message);
                        continue;
                    }
                }
                readerProduse.Close();

                OleDbCommand cmdIng = new OleDbCommand("SELECT * FROM Ingrediente", con);
                OleDbDataReader readerIng = cmdIng.ExecuteReader();
                while (readerIng.Read())
                {
                    int codProdus = Convert.ToInt32(readerIng["CodProdus"]);
                    int idMaterie = Convert.ToInt32(readerIng["IdMateriePrima"]);
                    double cantitate = Convert.ToDouble(readerIng["Cantitate"]);

                    // Since CodProdus can have duplicates, we may need to handle this differently
                    // For now, associate ingredients with the first matching product
                    var produs = dm.Produse.FirstOrDefault(p => p.CodProdus == codProdus);
                    var materie = DataManager.HashMateriiPrime.Values.FirstOrDefault(m => m.IDMateriePrima == idMaterie);

                    if (produs != null && materie != null)
                    {
                        produs.AdaugaIngredient(new IngredientProdus(materie, cantitate));
                    }
                }
                readerIng.Close();
            }
        }

        public static void SalveazaTot()
        {
            var dm = DataManager.Instance;

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();

                foreach (var m in dm.MateriiPrime)
                {
                    string tip = m.Tip;
                    double valoareSpecific = 0;

                    if (m is MateriePrimaLichida lichida)
                        valoareSpecific = lichida.vascozitate;
                    else if (m is MateriePrimaSolida solida)
                        valoareSpecific = solida.densitate;

                    OleDbCommand checkCmd = new OleDbCommand("SELECT COUNT(*) FROM MateriePrima WHERE Nume = ?", con);
                    checkCmd.Parameters.AddWithValue("?", m.nume);
                    int exista = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exista == 0)
                    {
                        OleDbCommand cmd = new OleDbCommand(
                            "INSERT INTO MateriePrima (Nume, UnitateDeMasura, Tip, Cost, Vascozitate, Densitate) VALUES (?, ?, ?, ?, ?, ?)", con);

                        cmd.Parameters.AddWithValue("?", m.nume);
                        cmd.Parameters.AddWithValue("?", m.um);
                        cmd.Parameters.AddWithValue("?", tip);
                        cmd.Parameters.AddWithValue("?", m.cost);

                        object valoareVasco = DBNull.Value;
                        object valoareDens = DBNull.Value;

                        if (tip == "Lichida")
                            valoareVasco = valoareSpecific;
                        else if (tip == "Solida")
                            valoareDens = valoareSpecific;

                        cmd.Parameters.AddWithValue("?", valoareVasco);
                        cmd.Parameters.AddWithValue("?", valoareDens);

                        cmd.ExecuteNonQuery();
                    }
                }

                foreach (var p in dm.Produse)
                {
                    try
                    {
                        // Verificare și corectare dată invalidă
                        if (p.DataProductie <= DateTime.MinValue || p.DataProductie.Year < 1900)
                            p.DataProductie = DateTime.Now;

                        // Verificare CodProdus
                        if (p.CodProdus <= 0)
                            throw new Exception("CodProdus invalid");

                        OleDbCommand comanda = new OleDbCommand();
                        comanda.Connection = con;

                        // Comanda de inserare
                        comanda.CommandText = "INSERT INTO Produs (NumeProdus, Pret, Cantitate, DataProductie, CodProdus) VALUES (?, ?, ?, ?, ?)";

                        // Parametri numiți + tipuri corespunzătoare Access
                        comanda.Parameters.Add("NumeProdus", OleDbType.VarChar, 255).Value = p.NumeProdus;
                        comanda.Parameters.Add("Pret", OleDbType.Double).Value = p.Pret;
                        comanda.Parameters.Add("Cantitate", OleDbType.Double).Value = p.Cant;
                        comanda.Parameters.Add("DataProductie", OleDbType.Date).Value = p.DataProductie;
                        comanda.Parameters.Add("CodProdus", OleDbType.Integer).Value = p.CodProdus;

                        comanda.ExecuteNonQuery();

                        // Obține IDProdus generat (cheia AutoNumber)
                        OleDbCommand getIdCmd = new OleDbCommand("SELECT @@IDENTITY", con);
                        int idProdusGenerat = Convert.ToInt32(getIdCmd.ExecuteScalar());

                        // Inserare ingrediente
                        foreach (var ing in p.ingrediente)
                        {
                            if (ing.Materie == null)
                                continue;

                            OleDbCommand cmdIng = new OleDbCommand(
                                "INSERT INTO Ingrediente (IdMateriePrima, IDProdus, Cantitate) VALUES (?, ?, ?)", con);

                            cmdIng.Connection = con;
                            cmdIng.Parameters.Add("IdMateriePrima", OleDbType.Integer).Value = ing.Materie.IDMateriePrima;
                            cmdIng.Parameters.Add("IDProdus", OleDbType.Integer).Value = idProdusGenerat;
                            cmdIng.Parameters.Add("Cantitate", OleDbType.Double).Value = ing.Cantitate;

                            cmdIng.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare la salvarea produsului cu CodProdus {p.CodProdus}:\n{ex.Message}",
                            "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        
    }
}