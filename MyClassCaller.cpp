#include "stdafx.h"
#include "MyClassCaller.h"

MyClass* Create()
{
	return new MyClass();
}

void Dispose(MyClass* a_pObject)
{
	if (a_pObject != NULL)
	{
		delete a_pObject;
		a_pObject = NULL;
	}
}

void SetFoo_1(MyClass* a_pObject)
{
	if (a_pObject != nullptr)
	{
		a_pObject->SetFoo_1();		 
	}
}

int GetEAX(MyClass* a_pObject)
{
	if (a_pObject != NULL)
	{
		return a_pObject->GetEAX();
	}
	return 0;
}