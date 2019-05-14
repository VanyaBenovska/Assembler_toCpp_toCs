#pragma once
#include "MyClass.h"      

#ifdef __cplusplus

extern "C" {
#endif

	 __declspec(dllexport) MyClass* Create();
	 __declspec(dllexport) void Dispose(MyClass* a_pObject);
	 __declspec(dllexport) void SetFoo_1(MyClass* a_pObject);
	 __declspec(dllexport) int GetEAX(MyClass* a_pObject);

#ifdef __cplusplus
}
#endif
