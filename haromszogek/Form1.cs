﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace haromszogek
{
    public partial class frmFo : Form
    {
        private double aOldal;
        private double bOldal;
        private double cOldal;

        public frmFo()
        {
            aOldal = 0;
            bOldal = 0;
            cOldal = 0;
            InitializeComponent();
            tbAoldal.Text = aOldal.ToString();
            tbBoldal.Text = bOldal.ToString();
            tbColdal.Text = cOldal.ToString();
            lbHaromszogLista.Items.Clear();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                aOldal = Convert.ToDouble(tbAoldal.Text);
                bOldal = Convert.ToDouble(tbBoldal.Text);
                cOldal = Convert.ToDouble(tbColdal.Text);

                StringBuilder szoveg = new StringBuilder();
                szoveg.Append("a: ");
                szoveg.Append(aOldal.ToString());
                szoveg.Append(" b: ");
                szoveg.Append(bOldal.ToString());
                szoveg.Append(" c: ");
                szoveg.Append(cOldal.ToString());

                if (aOldal == 0 || bOldal == 0 || cOldal == 0)
                {
                    MessageBox.Show("Nem lehet 0 a háromszög oldala!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var h = new Haromszog(aOldal, bOldal, cOldal);

                    List<string> adatok = h.AdatokSzoveg();
                    foreach (var a in adatok)
                    {
                        lbHaromszogLista.Items.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Számot adj meg!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbAoldal.Focus();
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (lbHaromszogLista.Items.Count > 0)
            {
                lbHaromszogLista.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nincs mit törölni!");
            }
        }

        private void btnFajlbol_Click(object sender, EventArgs e)
        {
            lbHaromszogLista.Items.Clear();
            if (ofdMegnyitas.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader file = new StreamReader(ofdMegnyitas.FileName);
                    try
                    {
                        while (!file.EndOfStream)
                        {
                            string sor = file.ReadLine();
                            var h = new Haromszog(sor);

                            lbHaromszogLista.Items.Add("Fájlból olvasás:");
                            foreach (var a in h.AdatokSzoveg())
                            {
                                lbHaromszogLista.Items.Add(a);
                            }
                            lbHaromszogLista.Items.Add("---------------------------");
                        }
                        file.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        file.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
