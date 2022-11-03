using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class SuperheroesVM : INotifyPropertyChanged
    {
        private Superheroe personaje;

        public Superheroe Personaje
        {
            get { return personaje; }
            set { personaje = value;
                this.NotifyPropertyChanged("Personaje");
            }
        }
        private int posicion;

        public int Posicion
        {
            get { return posicion; }
            set { posicion = value;
                this.NotifyPropertyChanged("Posicion");
            }
        }
        private int nHeroes;

        public int NHeroes
        {
            get { return nHeroes; }
            set { nHeroes = value;
                this.NotifyPropertyChanged("NHeroes");
            }
        }
        private List<Superheroe> listaSuperheroe = Superheroe.GetSamples();
        public SuperheroesVM()
        {
            this.Personaje = listaSuperheroe[0];
            this.Posicion = 1;
            this.NHeroes = listaSuperheroe.Count;
        }

        public void Avanzar()
        {
            if(Posicion < NHeroes)
            {
                Posicion++;
                Personaje = listaSuperheroe[Posicion - 1];
            }
            
        }

        public void Retroceder()
        {
            if(Posicion > 1)
            {
                Posicion--;
                Personaje = listaSuperheroe[Posicion - 1];
            }
            
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
