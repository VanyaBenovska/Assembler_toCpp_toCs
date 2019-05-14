#include "stdafx.h"
#include <iostream>
#include <cstdio>
#include <string>
#include <ctime>
#include <fstream>
#include <cstdlib>
#include <windows.h>
#include <malloc.h> 
//#include <stdlib.h> 
#include <stdio.h>
#include <sstream>

#include "MyClass.h"

//#define TOTALBYTES    8192
#define BYTEINCREMENT 4096


int MyClass::Foo_1()
{
	__asm
	{
		mov eax, 1
	}
}

void MyClass::SetFoo_1()
{
	resultEAX = new int;

	try
	{
		int a = Foo_1();
		if (a == 1)
		{
			*resultEAX = 1;
		}
	}
	catch (int e)
	{
		*resultEAX = 0;
	}
}

int MyClass::GetEAX() {
	return *resultEAX;
}
