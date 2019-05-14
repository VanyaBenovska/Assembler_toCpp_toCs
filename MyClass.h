
#ifndef MYCLASS_H
#define MYCLASS_H

class __declspec(dllexport) MyClass
{
public:	
	int * resultEAX ;

	int Foo_1();	
	void SetFoo_1();
	int  GetEAX();
};
#endif