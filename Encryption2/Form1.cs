using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CryptSharp;
using System.Threading;

namespace Encryption2
{
    public partial class Form1 : Form
    {
        private string original;
        DateTime starttime;
        DateTime endtime;

        private string encrypted;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            original = stringbox.Text;
            stringbox.Text = "";
            encrypted = CryptSharp.BlowfishCrypter.Blowfish.Crypt(original);
            encryptedString.Text = encrypted;
            encryptedBox.Text = encrypted;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            /*bool result = false;
            byte[] test = new byte[255];
            char[] chars = new char[255];
            for (int asc = 0; asc < 255; asc++)
            {
                test[0] = Convert.ToByte(asc);
                string check = System.Text.ASCIIEncoding.ASCII.GetString(test);

                result = Sha256Crypter.CheckPassword(check, encrypted);
                if (result)
                {
                    MessageBox.Show(result.ToString() + " Answer = " + check);
                    break;
                }
            }*/
            starttime = DateTime.Now;
            Decrypt(0, 32);
            //Handler();
        } 
        byte[] combination = new byte[10];
        private void Decrypt(int characters, byte bit, int last = 0)
        {
            combination = new byte[255];
            bool result = false;
            string check = "";
            while (!result)
                for (int i = 0; i <= characters; i++)
                {
                    for (int j = 32; j < 137; j++)
                    {
                        combination[i] = Convert.ToByte(j);
                        /*for (int k = 32; k < 137; k++)
                        {
                            combination[1] = Convert.ToByte(k);*/
                        check = System.Text.ASCIIEncoding.ASCII.GetString(combination);
                        result = BlowfishCrypter.CheckPassword(check, encrypted);
                        if (result)
                        {
                            break;
                        }
                        //}
                    }

                }
            if (result)
            {
                endtime = DateTime.Now;
                MessageBox.Show("Started at: " + starttime.ToString() + " Ended at: " + endtime.ToString());
                MessageBox.Show("Decrypted pass: " + check);
            }
            else
            {
                if (bit >= 137)
                {
                    if (characters >= last)
                    {
                        characters = 0;
                        last++;
                    }
                    else
                        characters++;
                    bit = 32;
                    //Result.Text = "Done with character nr " + characters.ToString();
                    MessageBox.Show("Done with character nr " + characters.ToString());
                    Decrypt(characters, bit, last);
                }
                else
                {
                    bit++;
                    Decrypt(characters, bit);
                }
            }
        }


        private void Handler()
        {
            bool done = false;
            string check = "";
            while (!done)
            {
                for (int i = 0; i < 255; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        for (int k = 32; k < 137; k++)
                        {
                            DecryptNew(j, (byte)k);
                            check = Encoding.ASCII.GetString(combination);
                            done = Crypter.CheckPassword(check, encrypted);
                            if (done)
                            {
                                //MessageBox.Show("Result");
                                endtime = DateTime.Now;
                                MessageBox.Show("Started at: " + starttime.ToString() + " Ended at: " + endtime.ToString());
                                MessageBox.Show("Decrypted pass: " + check);
                                return;
                            }
                        }
                        if (done)
                        {
                            //MessageBox.Show("Result");
                            endtime = DateTime.Now;
                            MessageBox.Show("Started at: " + starttime.ToString() + " Ended at: " + endtime.ToString());
                            MessageBox.Show("Decrypted pass: " + check);
                            return;

                        }
                        else
                        {
                            //MessageBox.Show("It is longer than " + (j + 1) + " characters...");
                        }
                    }
                }
                if (done)
                {
                    //MessageBox.Show("Result");
                    endtime = DateTime.Now;
                    MessageBox.Show("Started at: " + starttime.ToString() + " Ended at: " + endtime.ToString());
                    MessageBox.Show("Decrypted pass: " + check);
                    return;
                }
            }
            if (done)
            {
                endtime = DateTime.Now;
                MessageBox.Show("Started at: " + starttime.ToString() + " Ended at: " + endtime.ToString());
                MessageBox.Show("Decrypted pass: " + check);
            }
        }
        private void DecryptNew (int chars, byte bit)
        {

            combination[chars] = bit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stringbox.Focus();
        }
    }
}
