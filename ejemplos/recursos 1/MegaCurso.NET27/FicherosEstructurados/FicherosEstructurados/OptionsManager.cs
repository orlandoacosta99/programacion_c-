using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FicherosEstructurados
{
    public class OptionsManager
    {

        private Dictionary<string, PropertyInfo> propDict;


        public OptionsManager()
        {
            //initialize reflection dictionary
            Type masterOptionsType = typeof(MasterOptions);
            PropertyInfo[] properties = masterOptionsType.GetProperties();
            propDict = properties.ToDictionary(p => p.Name, p => p);
        }



        public MasterOptions Read()
        {
            MasterOptions options = new MasterOptions();


            using (FileStream fs = new FileStream("options.dat", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (sr.Peek() >= 0)
                    {
                        string line = sr.ReadLine();
                        string[] tokens = line.Split('=');

                        string propName = tokens[0];
                        string propValue = tokens[1];

                        PropertyInfo property = propDict[propName];

                        //boolean
                        if (property.PropertyType == typeof(bool))
                        {
                            property.SetValue(options, bool.Parse(propValue));
                        }
                        //color
                        else if(property.PropertyType == typeof(Color))
                        {
                            string[] colorTokens = propValue.Split(',');
                            Color tempColor = Color.FromArgb(
                                int.Parse(colorTokens[0]),
                                int.Parse(colorTokens[1]),
                                int.Parse(colorTokens[2]),
                                int.Parse(colorTokens[3])
                            );

                            property.SetValue(options, tempColor);
                        }
                        //int
                        else if(property.PropertyType == typeof(int))
                        {
                            property.SetValue(options, int.Parse(propValue));
                        }
                        //strings
                        else
                        {
                            property.SetValue(options, propValue);
                        }

                    }
                }
            }


            return options;

        }



        public void Save(MasterOptions options)
        {
            using (FileStream fs = new FileStream("options.dat", FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (PropertyInfo property in propDict.Values)
                    {
                        object value = property.GetValue(options);

                        if (property.PropertyType == typeof(Color))
                        {
                            Color color = (Color)value;
                            sw.WriteLine(property.Name + "=" + color.A + "," + color.R + "," + color.G + "," + color.B);
                        }
                        else
                        {
                            sw.WriteLine(property.Name + "=" + (value == null ? "" : value.ToString()));
                        }
                    }
                }
            }

        }

    }
}
