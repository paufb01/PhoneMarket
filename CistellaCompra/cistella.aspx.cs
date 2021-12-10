using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CistellaCompra
{
    public partial class cistella : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //PRODUCTE 1

            if ((Session["n_producte1"] != null) &&
                (Session["preu_prod1"] != null) &&
                (Session["n1"] != null))
            {

                int preu_prod1 = int.Parse((string)Session["preu_prod1"]);
                int quantitat1 = (int)Session["n1"];
                int preuTotal1 = preu_prod1 * quantitat1;

                Label2.Text = "Nom del model: " + Session["n_producte1"].ToString() + "  Preu: " + preu_prod1 + "€" + "  Quantitat: " + quantitat1 + "  Preu total: " + preuTotal1 + "€" + "<br/>";
            }
            else
            {
                Label2.Text = "";

            }


            //PRODUCTE 2

            if ((Session["n_producte2"] != null) &&
           (Session["preu_prod2"] != null) &&
           (Session["n2"] != null))
            {

                int preu_prod2 = int.Parse((string)Session["preu_prod2"]);
                int quantitat2 = (int)Session["n2"];
                int preuTotal2 = preu_prod2 * quantitat2;

                Label2.Text += "Nom del model: " + Session["n_producte2"].ToString() + "  Preu: " + preu_prod2 + "€" + "  Quantitat: " + quantitat2 + "  Preu total: " + preuTotal2 + "€" + "<br/>";
            }
            else
            {

                Label2.Text += "";

            }
            //PRODUCTE 3

            if ((Session["n_producte3"] != null) &&
           (Session["preu_prod3"] != null) &&
           (Session["n3"] != null))
            {


                int preu_prod3 = int.Parse((string)Session["preu_prod3"]);
                int quantitat3 = (int)Session["n3"];
                int preuTotal3 = preu_prod3 * quantitat3;


                Label2.Text += "Nom del model: " + Session["n_producte3"].ToString() + "  Preu:  " + preu_prod3 + "€" + "  Quantitat: " + quantitat3 + "  Preu Total: " + preuTotal3 + "€" + "<br/>";

            }
            else
            {
                Label2.Text += "";

            }
            //PRODUCTE 4


            if ((Session["n_producte4"] != null) &&
           (Session["preu_prod4"] != null) &&
           (Session["n4"] != null))
            {

                int preu_prod4 = int.Parse((string)Session["preu_prod4"]);
                int quantitat4 = (int)Session["n4"];
                int preuTotal4 = preu_prod4 * quantitat4;


                Label2.Text += "Nom del model: " + Session["n_producte4"].ToString() + "  Preu: " + preu_prod4 + "€" + "  Quantitat: " + quantitat4 + "  Preu Total: " + preuTotal4 + "€";


            }
            else
            {
                Label2.Text += "";

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("produkts.aspx");
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            ArchivSchreiben();
            Label6.Text = "S'ha realitzat la comanda satisfactòriament. ";

        }



        //ESCRIURE FITXER 

        public void ArchivSchreiben()
                {
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";

            string inputNom = TextBox1.Text;
            string inputDni = TextBox2.Text;


            int err;
            bool nBuit = string.IsNullOrEmpty(inputNom);
            bool NesNum = int.TryParse(inputNom, out err);

            bool nBuitDNI = string.IsNullOrEmpty(inputDni);


            if ((nBuit = true) && (NesNum == true))
            {
                Label7.Text = "ERROR: Camp buit o format incorrecte";
            }

            else if (nBuitDNI == true)
            {
                Label8.Text = "ERROR: Camp buit o format incorrecte";
            }

            else
            {
                int numTelf = int.Parse(TextBox3.Text);

                    DateTime dataFact = DateTime.Now;


                string dataNova = dataFact.ToString();
                string[] data = dataNova.Split(' ');
                string dia = data[0].Replace("/", "_");
                string hora = data[1].Replace(":", ".");
                string dataActual = dia + hora;


                string rutaComandes = Server.MapPath("./comandes/" + inputDni+ dataActual  + ".txt");
                    StreamWriter sw = new StreamWriter(rutaComandes);
                    sw.WriteLine("Nom i Cognoms: " + inputNom);
                    sw.WriteLine("NIF: " + inputDni);
                    sw.WriteLine("Telèfon: " + numTelf);
                    sw.WriteLine("Data de facturació:  " + dataFact.ToString());
                    sw.WriteLine("------------------------");
                    sw.WriteLine("\n \n Compra:");
                     sw.WriteLine("------------------------");



                    if ((Session["n_producte1"] != null) &&
                         (Session["preu_prod1"] != null) &&
                         (Session["n1"] != null))
                    {

                        int preu_prod1 = int.Parse((string)Session["preu_prod1"]);
                        int quantitat1 = (int)Session["n1"];
                        int preuTotal1 = preu_prod1 * quantitat1;
                        sw.WriteLine("");
                        sw.WriteLine("------------------------");
                        sw.WriteLine("Nom del model: " + Session["n_producte1"].ToString());
                        sw.WriteLine("Preu: " + preu_prod1 + "€");
                        sw.WriteLine("Quantitat: " + quantitat1);
                        sw.WriteLine("Preu total: " + preuTotal1 + "€");
                    }

                    if ((Session["n_producte2"] != null) &&
                        (Session["preu_prod2"] != null) &&
                        (Session["n2"] != null))
                    {

                        int preu_prod2 = int.Parse((string)Session["preu_prod2"]);
                        int quantitat2 = (int)Session["n2"];
                        int preuTotal2 = preu_prod2 * quantitat2;

                        sw.WriteLine("");
                        sw.WriteLine("------------------------");
                        sw.WriteLine("Nom del model: " + Session["n_producte2"].ToString());
                        sw.WriteLine("Preu: " + preu_prod2 + "€");
                        sw.WriteLine("Quantitat: " + quantitat2);
                        sw.WriteLine("Preu total: " + preuTotal2 + "€");
                    }


                    if ((Session["n_producte3"] != null) &&
                        (Session["preu_prod3"] != null) &&
                        (Session["n3"] != null))
                    {

                        int preu_prod3 = int.Parse((string)Session["preu_prod3"]);
                        int quantitat3 = (int)Session["n3"];
                        int preuTotal3 = preu_prod3 * quantitat3;

                        sw.WriteLine("");
                        sw.WriteLine("------------------------");
                        sw.WriteLine("Nom del model: " + Session["n_producte3"].ToString());
                        sw.WriteLine("Preu: " + preu_prod3 + "€");
                        sw.WriteLine("Quantitat: " + quantitat3);
                        sw.WriteLine("Preu total: " + preuTotal3 + "€");
                    }

                    if ((Session["n_producte4"] != null) &&
                        (Session["preu_prod4"] != null) &&
                        (Session["n4"] != null))
                    {

                        int preu_prod4 = int.Parse((string)Session["preu_prod4"]);
                        int quantitat4 = (int)Session["n4"];
                        int preuTotal4 = preu_prod4 * quantitat4;

                        sw.WriteLine("");
                        sw.WriteLine("------------------------");
                        sw.WriteLine("Nom del model: " + Session["n_producte4"].ToString());
                        sw.WriteLine("Preu: " + preu_prod4 + "€");
                        sw.WriteLine("Quantitat: " + quantitat4);
                        sw.WriteLine("Preu total: " + preuTotal4 + "€");



                    }
                   


                    sw.Close();
                }
             }
             

            }
        }

    


