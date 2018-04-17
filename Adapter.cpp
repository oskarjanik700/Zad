#include <iostream>

using namespace std;


typedef int Dimension;

// Desired interface
class A
{
  public:
  virtual void draw() = 0;
};

// Legacy component
class B
{
  public:
    B(int a, int b)
    {
        x = a;
        y = b;

        cout << "B: create.  (" << x << "," << y << ")" << endl;

    }
    void oldDraw()
    {
        cout << "B:  oldDraw.  (" << x << "," << y << ")" << endl;
    }
  private:
    int x;
    int y;

};

// Adapter wrapper
class Adapter: private B, public A
{
  public:
    Adapter(int a, int b):
      B(a, b)
    {
        cout << "B: create.  (" << a << "," << b << ")" << endl;

    }
    virtual void draw()
    {
        cout << "Adapter: draw." << endl;
        oldDraw();
    }
};

int main()
{
  A *r = new Adapter(13, 25);
  r->draw();
}

