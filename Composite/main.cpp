#include <iostream>
#include <vector>
using namespace std;

class Component
{
  public:
    virtual void traverse() = 0;
};

class Leaf: public Component
{

    int val;
  public:
    Leaf(int v)
    {
        val = v;
    }
    void traverse()
    {
        cout << val << ' ';
    }
};

class Composite: public Component
{

    vector < Component * > child;
  public:

    void add(Component *e)
    {
        child.push_back(e);
    }
    void traverse()
    {
        for (int i = 0; i < child.size(); i++)

          child[i]->traverse();
    }
};

int main()
{
  Composite containers[4];

  for (int i = 0; i < 4; i++)
    for (int j = 0; j < 3; j++)
      containers[i].add(new Leaf(i *3+j));

  for (int i = 1; i < 4; i++)
    containers[0].add(&(containers[i]));

  for (int i = 0; i < 4; i++)
  {
    containers[i].traverse();
    cout << endl;
  }
}
