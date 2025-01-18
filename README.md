# Lotka-Volterra model building 
This project is a solution to one of the tasks set in practice.

![image](https://github.com/user-attachments/assets/59035000-463c-44da-8e9f-5d1b51b0eb59)

# Problem Description
Using the predator-prey relationship modeling method for option 1:
1. Describe the interaction of 2-x populations using appropriate kinetic equations under different parameters and initial conditions;
2.	Construct a phase portrait of the system;
3.	Investigate using a PC at which parameter ratios the predator-prey model practically transforms into a natural growth model.
Assumptions:
- “Predator” and “Victim” inhabit some space;
- “Victim” has no competition for space, food resources;
- “Victim” has: reproduction process, natural death, death by “Predator”;
- “Predator” feeds only on “Victim”;
- Predator and Victim populations do not take into account biochemical physiological processes.

# Required formulas and notations:
x_0 - initial number of victims;

y_0 - initial number of predators;

x_ST - stationary value of the number of victims;

y_ST - stationary value of the number of predators;

γ - specific birth rate of “victim”; 

δ - specific fertility rate of the “predator”;

σ - specific natural mortality rate of the “victim”;

β - specific natural mortality rate of the “predator”;

ε - biotic potential of the victim population;

(γ - σ) - growth coefficient;

α - coefficient of death due to victim-predator encounter (1/α - thinning of the population by 1/α times);

β - coefficient of natural predator mortality;

xt - number of “victims” at time t;

yt - number of “victims” at time t.

# Example of use

Baseline data:
- System: Amur tiger - wild boar;
- ε,unit/year: 0.3;
- β,units/year: 0.2;
- α: 0,0005;
- х0: 1000;
- y0: 300;
- δ: 0,0002;


The program execution resulted in the diagram from the figure. 

![image](https://github.com/user-attachments/assets/9f9b6dc5-3bec-4135-b7af-17df085cb6ee)
