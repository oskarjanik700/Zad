#include <iostream>

using namespace std;

class RealImage
{
    int id;
  public:
    RealImage(int i)
    {
        id = i;
        cout << "   constructor: " << id << '\n';
    }
    ~RealImage()
    {
        cout << "   destructor: " << id << '\n';
    }
    void draw()
    {
        cout << "   drawing image " << id << '\n';
    }
};

// 1. Design an "extra level of indirection" wrapper class
class Image
{
    // 2. The wrapper class holds a pointer to the real class
    RealImage *real_thing;
    int id;
    static int s_next;
  public:
    Image()
    {
        id = s_next++;
        // 3. Initialized to null
        real_thing = 0;
    }
    ~Image()
    {
        delete real_thing;
    }
    void draw()
    {
        // 4. When a request comes in, the real object is
        //    created "on first use"
        if (!real_thing)
          real_thing = new RealImage(id);
        // 5. The request is always delegated
        real_thing->draw();
    }
};
int Image::s_next = 1;

int main()
{
  Image images[5];

  for (int i; true;)
  {
    cout << "Exit[0], Image[1-5]: ";
    cin >> i;
    if (i == 0)
      break;
    images[i - 1].draw();
  }
}
