/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ndigitintadder;

/**
 *
 * @author hrvoje
 */
public class BigInt {
    
    StringBuilder number;
    
    public BigInt(String number) {
        this.number = new StringBuilder();
        this.number.append(number);
    }
    
    public String Add(BigInt number){
        
        StringBuilder result = new StringBuilder();
        int one = 0;
        int two = 0;
        int additionResult = 0;
        int overflow = 0;
        
        if(this.number.length() != 0 && number.number.length() != 0){
            if(ShorterNumber(this.number, number.number) == 1){
                int index = this.number.length() - 1;
                while(index >= 0){
                    do{
                        one = (int)this.number.charAt(index) - 48;
                        two = (int)number.number.charAt(index) - 48;
                        
                        
                        if(one + two + overflow == 10){
                            additionResult = 0;
                            overflow = 1;
                        }
                        else if(one + two + overflow > 10){
                            additionResult = (one + two + overflow) % 10;
                            overflow = 1;
                        }
                        else {
                            additionResult = one + two + overflow;
                            overflow = 0;
                        }
                        
                        result.append(String.valueOf(additionResult));
                        index--;
                        
                        if(index == -1){
                            result.append(String.valueOf(overflow));
                            result.reverse();
                            
                            return result.toString();
                        }
                    }while(overflow > 0);
                }
            }
        }
        
        result.reverse();
        
        return result.toString();
    }
    
    private int ShorterNumber(StringBuilder one, StringBuilder two){
        if(one.length() <= two.length()){
            return 1;
        }
        else {
            return 2;
        }
    }
}
