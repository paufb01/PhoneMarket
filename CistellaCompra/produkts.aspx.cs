using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CistellaCompra
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          string arxiu;
            
        Label6.Text = "";
        Label7.Text = "";
        Label8.Text = "";
        Label9.Text = "";

            //QUANTITAT DEL PRODUCTE

        
            int producto = 1;

            for (int i = 1; i < 7; i++)
            {
                arxiu = readFile(i);

                if (validacio(i) && (arxiu!=""))
                {
                    if (producto == 1)
                    {
                        Image1.ImageUrl = "./Productes/" + i + ".png";
                        string[] parts = arxiu.Split(';');
                        Label2.Text = parts[0] + "<br/>";
                        Label2.Text+= "Preu: " + parts[1] + "€" + "<br/>";
                       
                        Label2.Text += parts[2];

                        String n_producte = parts[0];
                        Session["n_producte1"] = n_producte;
                        string preu_prod1 = parts[1];
                        Session["preu_prod1"] = preu_prod1;
                        producto++;
                    }
                    else if (producto == 2)
                    {
                        Image2.ImageUrl = "./Productes/" + i + ".png";
                        string[] parts = arxiu.Split(';');
                        Label3.Text = parts[0] + "<br/>";
                        Label3.Text += "Preu: " + parts[1] + "€" + "<br/>";
                        Label3.Text += parts[2];


                        String n_producte2 = parts[0];
                        Session["n_producte2"] = n_producte2;
                        String preu_prod2 = parts[1];
                        Session["preu_prod2"] = preu_prod2;


                        producto++;

                    }
                    else if (producto == 3)
                    {
                        Image3.ImageUrl = "./Productes/" + i + ".png";
                        string[] parts = arxiu.Split(';');
                        Label4.Text = parts[0] + "<br/>";
                        Label4.Text += "Preu: " + parts[1] + "€" + "<br/>";
                        Label4.Text += parts[2];

                        String n_producte3 = parts[0];
                        Session["n_producte3"] = n_producte3;
                        String preu_prod3 = parts[1];
                        Session["preu_prod3"] = preu_prod3;


                        producto++;
                    }
                    else if (producto == 4)
                    {
                        Image4.ImageUrl = "./Productes/" + i + ".png";
                        string[] parts = arxiu.Split(';');
                        Label5.Text = parts[0] + "<br/>";
                        Label5.Text += "Preu: " + parts[1] + "€" + "<br/>";
                        Label5.Text += parts[2];

                        String n_producte4 = parts[0];
                        Session["n_producte4"] = n_producte4;
                        String preu_prod4 = parts[1];
                        Session["preu_producte4"] = preu_prod4;


                        producto++;
                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             try
            {

                int n1 = int.Parse(TextBox1.Text);
                if (n1 <= 0)
                {
                    Label6.Text = "ERROR: Ha d'introduir un nombre més gran que 0!";
                }
                else 
                {
                    Session["n1"] = n1;
                    string correcte1 = "S'ha afegit " + n1 + " " + Session["n_producte1"] + " correctament.";
                    Session["correcte1"] = correcte1;
                    Label10.Text = correcte1;

                }
            }
            catch (Exception)
            {
                Label6.Text = "ERROR: Ha d'introduir una quantitat en nombres enters.";
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n2 = int.Parse(TextBox2.Text);
                if (n2 <= 0)
                {
                    Label7.Text = "ERROR: Ha d'introduir un nombre més gran que 0!";
                }
                else
                {
                    Session["n2"] = n2;
                    Label11.Text = "S'ha afegit" + n2 + " " + Session["n_producte2"] + " correctament.";

                }
            }
            catch (Exception)
            {
            Label7.Text = "ERROR: Ha d'introduir una quantitat en nombres enters.";
            }
               
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
             try
            {
                int n3 = int.Parse(TextBox3.Text);

                if (n3 <= 0)
                {
                    Label8.Text = "ERROR: Ha d'introduir un nombre més gran que 0!";
                }
                else
                {
                    Session["n3"] = n3;
                    Label12.Text = "S'ha afegit" + n3 + " " + Session["n_producte3"] + " correctament.";
                }
            }
            catch (Exception)
            {
                Label8.Text = "ERROR: Ha d'introduir una quantitat en nombres enters.";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
             try
            {
                int n4 = int.Parse(TextBox4.Text);
                if (n4 <= 0)
                {
                    Label9.Text = "ERROR: Ha d'introduir un nombre més gran que 0!";
                }
                
                
                else
                {
                    Session["n4"] = n4;
                    Label13.Text = "S'ha afegit" + n4 + " " + Session["n_producte4"] + " correctament.";


                }
            }
            catch (Exception)
            {
                Label9.Text = "ERROR: Ha d'introduir una quantitat en nombres enters.";


            }
        }
      protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("cistella.aspx");
        }


        public Boolean validacio(int x)

        {
            string rutaJPG = Server.MapPath("./Productes/" + x + ".png");
            string rutaTXT = Server.MapPath("./Productes/" + x + ".txt");

            if (File.Exists(rutaTXT) && File.Exists(rutaJPG))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public string readFile(int y)
        {
            string arxiu;
            string rutaTXT = Server.MapPath("./Productes/"+ y + ".txt");           
            StreamReader sr = new StreamReader(rutaTXT);
            arxiu = sr.ReadToEnd();
       
            
                string [] parts = arxiu.Split(';');


                if((parts[0] == "") || (parts[1]=="") || (parts[2] == ""))
                {
                     sr.Close();
                     return "";
                }     
            sr.Close();
            return arxiu;

        }

     
    }
}

