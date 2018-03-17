#include <iostream>

using namespace std;

class Inter {
  public:
    virtual ~Inter(){}
    virtual void Do() = 0;
};

class A: public Inter {
  public:
    ~A() {
        cout << "A destruktor" << '\n';
    }
    /*virtual*/
    void Do() {
        cout << 'A';
    }
};

class D: public Inter {
  public:
    D(Inter *inner) {
        m_wrappee = inner;
    }
    ~D() {
        delete m_wrappee;
    }
    /*virtual*/
    void Do() {
        m_wrappee->Do();
    }
  private:
    Inter *m_wrappee;
};

class X: public D {
  public:
    X(Inter *core): D(core){}
    ~X() {
        cout << "X destruktor" << "   ";
    }
    /*virtual*/
    void Do() {
        D::Do();
        cout << 'X';
    }
};

class Y: public D {
  public:
    Y(Inter *core): D(core){}
    ~Y() {
        cout << "Y destruktor" << "   ";
    }
    /*virtual*/
    void Do() {
        D::Do();
        cout << 'Y';
    }
};

class Z: public D {
  public:
    Z(Inter *core): D(core){}
    ~Z() {
        cout << "Z destruktor" << "   ";
    }
    /*virtual*/
    void Do() {
        D::Do();
        cout << 'Z';
    }
};

int main() {

  Inter *obiekt = new Z(new Y(new X(new A)));

  delete obiekt;
}

