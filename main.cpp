#include <iostream>
#include <list>

using namespace std;


class Singleton
{
    private:

        static Singleton* instance;


        Singleton();

        list<int> lista;


    public:


        static Singleton* getInstance();


        void dodaj(int x)
        {
             lista.push_back(x);
        }

        void usun(int i)
        {
            lista.remove(i);
        }

        void wyswietl()
        {
            for(int i = 0; i < lista.size(); i++)
            {
                auto s = next(lista.begin(), i);
                cout << *s << endl;
            }
        }
/*

        void usun()
        {
             Singleton *obecny = this;
             Singleton *tym;
            while(obecny != NULL)
            {
                tym = obecny->nast;

                delete obecny;

                obecny = tym;
            }


        }


         void wyswietl(Lista *ob)
        {
             Lista *obecny = ob;

            while(obecny != NULL)
            {
                cout << obecny->dane << endl;

                obecny = obecny->nast;
            }


        }*/


};


Singleton* Singleton::instance = 0;


Singleton* Singleton::getInstance()
{
    if (instance == 0)
    {
        instance = new Singleton();


    }


    return instance;
}

Singleton::Singleton()
{}



int main()
{
    Singleton *obiekt_listowy = Singleton::getInstance();

    obiekt_listowy->dodaj(32);
    obiekt_listowy->dodaj(44);
    obiekt_listowy->dodaj(78);
    obiekt_listowy->usun(44);

      obiekt_listowy->wyswietl();

}

