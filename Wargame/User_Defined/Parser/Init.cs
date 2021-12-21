using System;
using System.IO;
using System.Xml;
using Wargame.User_Defined.Tools;

namespace Parser
{
    class Init
    {
        static public void TerUnits()
        {
            XmlDocument doc = new XmlDocument();
            string thisDir = Tools.GetTrueDirectory(Directory.GetCurrentDirectory());

            doc.Load(thisDir + "Resources\\XML_Files\\groundUnits.xml");

            foreach (XmlElement elem in doc.GetElementsByTagName("unit"))
            {
                XmlNode node = elem.FirstChild;
                int ID;
                float HP, S_Atk, H_Atk, Defence, Armor, Pierce, Breakt, Fuel, Reliab, Org, A_Atk,
                    Entr, Combat_Wdt, Hardness;

                ID = int.Parse(elem.GetAttributeNode("id").Value);

                HP = float.Parse(node.InnerText);
                node = node.NextSibling;

                S_Atk = float.Parse(node.InnerText);
                node = node.NextSibling;

                H_Atk = float.Parse(node.InnerText);
                node = node.NextSibling;

                Defence = float.Parse(node.InnerText);
                node = node.NextSibling;

                Armor = float.Parse(node.InnerText);
                node = node.NextSibling;

                Pierce = float.Parse(node.InnerText);
                node = node.NextSibling;

                Breakt = float.Parse(node.InnerText);
                node = node.NextSibling;

                Fuel = float.Parse(node.InnerText);
                node = node.NextSibling;

                Reliab = float.Parse(node.InnerText);
                node = node.NextSibling;

                Org = float.Parse(node.InnerText);
                node = node.NextSibling;

                A_Atk = float.Parse(node.InnerText);
                node = node.NextSibling;

                Entr = float.Parse(node.InnerText);
                node = node.NextSibling;

                Combat_Wdt = float.Parse(node.InnerText);
                node = node.NextSibling;

                Hardness = float.Parse(node.InnerText);

                Wargame.Program.allTerUnits.Add(new Units.Ter_Unit(ID, HP, S_Atk, H_Atk, Defence, Armor, Pierce, Breakt, Fuel,
                    Reliab, Org, A_Atk, Entr, Combat_Wdt, Hardness));
            }


            Console.WriteLine("Ground Units initialized successfully!");
        }

        static public void AirUnits()
        {
            XmlDocument doc = new XmlDocument();
            string thisDir = Tools.GetTrueDirectory(Directory.GetCurrentDirectory());

            doc.Load(thisDir + "Resources\\XML_Files\\airUnits.xml");

            foreach (XmlElement elem in doc.GetElementsByTagName("unit"))
            {
                XmlNode node = elem.FirstChild;
                int ID;
                float HP, A_Atk, Gnd_Atk, Strat_Bmb, Air_Sup;

                ID = int.Parse(elem.GetAttributeNode("id").Value);

                HP = float.Parse(node.InnerText);
                node = node.NextSibling;

                A_Atk = float.Parse(node.InnerText);
                node = node.NextSibling;

                Gnd_Atk = float.Parse(node.InnerText);
                node = node.NextSibling;

                Strat_Bmb = float.Parse(node.InnerText);
                node = node.NextSibling;

                Air_Sup = float.Parse(node.InnerText);



                Wargame.Program.allAirUnits.Add(new Units.Air_Unit(ID, HP, A_Atk, Gnd_Atk, Strat_Bmb, Air_Sup));
            }

            Console.WriteLine("Air Units initialized successfully!");
        }
    }
}
