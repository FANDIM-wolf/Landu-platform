#include <stdio.h>
#include <math.h>
int main()
{
	double res;
	int angle;
	int argv[1]={1,25};

	if(argc <=1)
	return 0;

	atoi(argv[1],angle);
	res = sin(angle)*100;
	return res;	
}