#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

extern class Interfejs
{
  public:
    // Factory Method
    static Interfejs *make(int choice);

   // virtual void slap_stick() = 0;
    virtual vector<string> list_items() =0;
    virtual void add_item(string) =0;
    virtual vector<string> sort_items() =0;
    virtual void delete_item() =0;
};

extern class Products: public Interfejs
{
private:
    vector<string> items;
  public:
      void delete_item()
      {
          items.pop_back();

      }
     vector<string> list_items()
    {
        for(string x : items)
        {
            cout << x << endl;
        }
        return items;
    }
        void add_item(string name)
    {
        items.push_back(name);
    }
    vector<string> sort_items()
    {
        sort(items.begin(), items.end());
        return items;
    }
};
extern class Users: public Interfejs
{
    private:
    vector<string> items;

  public:
        void delete_item()
      {
          items.pop_back();

      }
     vector<string> list_items()
    {
        for(string x : items)
        {
            cout << x << endl;
        }
        return items;
    }
        void add_item(string name)
    {
        items.push_back(name);
    }
    vector<string> sort_items()
    {
        sort(items.begin(), items.end());
         return items;
    }
};
extern class Privileges: public Interfejs
{
    private:
    vector<string> items;
  public:
        void delete_item()
      {
          items.pop_back();

      }
   vector<string>  list_items()
    {
         for(string x : items)
        {
            cout << x << endl;
        }
        return items;
    }
        void add_item(string name)
    {
        items.push_back(name);
    }
    vector<string>  sort_items()
    {
        sort(items.begin(), items.end());
        return items;
    }
};

extern Interfejs *Interfejs::make(int choice)
{
  if (choice == 1)
    return new Products;
  else if (choice == 2)
    return new Users;
  else if (choice == 3)
    return new Privileges;
}

int main()
{
    Interfejs *obiekt = new Products();

    obiekt = Interfejs::make(3);

    obiekt->add_item("ITEM");

}


