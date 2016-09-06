using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreSAAD
{
    public class PlayTennis
    {
        public string Tempo { get; set; }
        public string Umidade { get; set; }
        public string Temperatura { get; set; }
        public string Vento { get; set; }
        protected bool play;


        public bool possoJogar(string tempo,string umidade,string temperatura,string vento)
        {
            Tempo = tempo;
            Umidade = umidade;
            Vento = vento;
            Temperatura = temperatura;
           
            if (Tempo == "Sunny" && Umidade == "High" && Temperatura == "Hot" && Vento == "Strong")
            {
                    this.play = false;
            }

            if (Tempo == "Sunny")
            {
                if (Umidade == "High" && Temperatura == "Hot" && Vento == "Weak")
                {
                    play = false;
                }
            }
            if (Tempo == "OverCast" && Umidade == "High" && Temperatura == "Hot" && Vento == "Weak")
            {
                play = true;
                   return play;
            }

            if (Tempo == "Rain")
            {
                if (Umidade == "High" && Temperatura == "Mild" && Vento == "Weak")
                {
                    return play = true;
                }
            }

            if (Tempo == "Rain")
            {
                if (Umidade == "High" && Temperatura == "Mild" && Vento == "Weak")
                {
                   return play = false;
                }
            }
            if (Tempo == "Rain")
            {
                if (Umidade == "Normal" && Temperatura == "Cool" && Vento == "Weak")
                {
                   return play = true;
                }
            }
            if (Tempo == "Rain")
            {
                if (Umidade == "Normal" && Temperatura == "Cool" && Vento == "Strong")
                {
                   return play = false;
                }
            }
            if (Tempo == "OverCast")
            {
                if (Umidade == "Normal" && Temperatura == "Cool" && Vento == "Strong")
                {
                    this.play = true;
                   return play;
                }
            }
            return play;
        }
    }
}
