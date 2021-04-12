# GeneticAlgorithm

It's the simple console implemantation of the genetic algorithm I have learned during my calsses. It's rewrited form orginal programme I've made in Matlab. 
Its aim is to find minimum value of the given function. It works properly on the function of two variables, but it won't be a problem to rebuilt this programme for three four or more variables. 

The general idea is:
1. we pick the max range we are going to search our solution (here X [-10,10] , Y [-10,10]).
2. set: 

    I. the number of population size - how many points we want to generate in each loop execution.
    
    II. n best succesors - form how many points we want to mutate coordinates and apply them to next generation.
    
    III. number of elite - elite point is the best point in each generation. It is remebered and is a part of the next generation.
    
    IV. how many tiumes we want to repeat our algorithm,
    
    V. how many variables our function has,
    
    VI. initial step - how far from current point we want to generate the next one in the first loop execution.  
    
    VII. Parameter P1 and P2 - they determine the convergence curve - ratio between exploration (when we search for next generation points in the wide area) and exploatation (when          we are searching for the precise value near already found points) and how fast and 'drastically' change form exploration to exploatation. 
3. Programme is generating a population of I. points and set values for them.
4. The II. is saved and based on them the new population is determined. The elite is remembered.
5. Generation points and values are repeated IV. times.
6. Meanwhile the mutation range is changing according to parameters P1, P2.
7. After all loop's repetitons we are given the minimum we found with it's coordinates. 
