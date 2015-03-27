/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gameoflife;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author hrvoje
 */
public class GameOfLife {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        final int size = 10;
        
        // The world is actually flat :O
        boolean[][] worldMatrix = new boolean[size][size];
        
        // Life found at
        worldMatrix[2][2] = true;
        worldMatrix[2][3] = true;
        worldMatrix[3][2] = true;
        worldMatrix[2][1] = true;
        worldMatrix[1][2] = true;
        worldMatrix[4][5] = true;
        worldMatrix[5][5] = true;
//        worldMatrix[4][6] = true;
//        worldMatrix[5][6] = true;
//        worldMatrix[4][7] = true;
//        worldMatrix[7][1] = true;
//        worldMatrix[8][1] = true;
//        worldMatrix[8][2] = true;
        
        while(true){
            
            worldMatrix = LetTheGameBegin(worldMatrix, size);
            Draw(worldMatrix, size);
            
            try {
                Thread.sleep(100);
            } catch (InterruptedException ex) {
                Logger.getLogger(GameOfLife.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }
    
    private static void Draw(boolean[][] world, int size){
        for (int i = 0; i < size; i++) {
                
                for (int j = 0; j < size; j++) {
                    if(world[i][j] == true){
                        System.out.print("*");
                    }
                    else{
                        System.out.print(" ");
                    }
                }
                System.out.println("");
            }
    }
    
    private static boolean[][] LetTheGameBegin(boolean[][] world, int size){
        
        int counter;
        boolean[][] newWorldMatrix = new boolean[size][size];
        
        for (int i = 0; i < size; i++) {
            counter = 0;
            
            for (int j = 0; j < size; j++) {
                counter = 0;
                
                // Check all neighbors if alive
                if(j < size - 1)
                    if(world[i][j+1] == true)
                        counter++;
                
                if(j > 0)
                    if(world[i][j-1] == true)
                        counter++;
                
                if(i > 0)
                    if(world[i-1][j] == true)
                        counter++;
                
                if(i < size - 1)
                    if(world[i+1][j] == true)
                        counter++;
                
                if(i > 0 && j > 0)
                    if(world[i-1][j-1] == true)
                        counter++;
                
                if(i != 0 && j < size - 1)
                    if(world[i-1][j+1] == true)
                        counter++;
                
                if(i < size - 1 && j > 0)
                    if(world[i+1][j-1] == true)
                        counter++;
                
                if(i < size - 1 && j < size - 1)
                    if(world[i+1][j+1] == true)
                        counter++;
                
                // Check which should live and die
                if(counter > 3 || counter < 2)
                    if(world[i][j] == true)
                        newWorldMatrix[i][j] = false;
                
                if(counter >= 2 && counter <= 3)
                    if(world[i][j] == true)
                        newWorldMatrix[i][j] = true;
                
                if(counter == 3)
                    if(world[i][j] == false)
                        newWorldMatrix[i][j] = true;
            }
        }
        
        return newWorldMatrix;
    }
}
