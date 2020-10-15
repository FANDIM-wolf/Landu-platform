#include <signal.h>
#include <stdio.h>

//get signal and input result
void handler(){
	signal(sig_no,&handler);
	printf("signal is gotten\n");

}
int main(){
	signal(SIGINT ,&handler);
	//wait , we need cautch signal 
	while(1){
		printf("Waitting for signal...\n");
		pause();
	}

	return 0;
}
