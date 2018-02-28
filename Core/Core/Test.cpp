extern "C"
{
	__declspec(dllexport) int iAdd(int a, int b)
	{
		return a+b;
	}

	__declspec(dllexport) int iSub(int* a, int* b)
	{
		return *a-*b;
	}
}