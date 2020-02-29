package chainOfResponsability;

//We are looking basing in the website https://www.journaldev.com/1617/chain-of-responsibility-design-pattern-in-java

import java.util.Scanner;

public class ATMDispenseChain {

	private DispenseChain c0;

	public ATMDispenseChain() {
		
		// initialize the chain
                this.c0 = new Dollar100Dispenser();
		DispenseChain c1  = new Dollar50Dispenser();
		DispenseChain c2 = new Dollar20Dispenser();
		DispenseChain c3 = new Dollar10Dispenser();

		// set the chain of responsibility
                c0.setNextChain(c1);
		c1.setNextChain(c2);
		c2.setNextChain(c3);
	}

	public static void execute() {
            /*I`ve changed the "void main" for "void execute" and created a new void main below
             calling the method void execute();
            */
		
		ATMDispenseChain atmDispenser = new ATMDispenseChain();
		
		 do{
                    
			int amount = 0;
                        System.out.println("");
			System.out.println("Enter amount to dispense");
			Scanner input = new Scanner(System.in);
			amount = input.nextInt();
			if (amount % 10 != 0|| amount <= 0) {
                            
				System.out.println("Amount should be in multiple of 10s.");
                                
                                //I made code after this line
                                System.out.println("Try again putting another amount.");
                                
                                ATMDispenseChain.execute();                               	
                                
                                /*
                                A ideia da CHAIN OF RESPONSABILITY é que tenha bastante
                                recursividade, seria possivel deixar o código rodando em looping da forma :
                                
                                do{
                                amount = input.nextInt();
                                }while(amount % 10 != 0|| amount <= 0);
                             
                                e também com o 
                                
                                main(args);  - Se fizer isso, faz o main rodar novamente
                                */
			}
                        
                        
			// process the request
			atmDispenser.c0.dispense(new Currency(amount));
		}while (true||false);

	}public static void main(String[] args) {
            execute();
        }
        

}
