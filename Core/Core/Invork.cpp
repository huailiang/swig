#include "Invork.h"

int Invork:: Mul(int a,int b)
{
	return a*b;
}

int Invork::Div(int a,int b)
{
	if(b==0)
	{
		return 0;
	}
	else
	{
		return a/b;
	}
}