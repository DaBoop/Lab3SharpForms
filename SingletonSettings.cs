using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Lab2SharpForms
{
    public sealed class SingletonSettings
    {
        private static SingletonSettings _instance;
        private static readonly object locker = new object();
        private SingletonSettings() 
        {
            backColor = Color.White;
            fontColor = Color.Black;
            fontSize = 16;
            mainFormWidth = 1274;
            mainFormHeight = 649;
        }

        public static SingletonSettings GetInstance()
        {
            if (_instance == null)
            {
                lock(locker)
                {
                    if (_instance == null)
                        _instance = new SingletonSettings();
                }
            }

            return _instance;
        }

        public Color backColor { get; set; }
        public Color fontColor { get; set; }

        public int fontSize { get; set; }

        public int mainFormWidth { get; set; }
        public int mainFormHeight { get; set; }
    }
}
