# Papas-Biologeria
Papa's Biologeria is an educational game aimed to teach users the fundamentals related to data science applications in biology. 

To ensure this project runs smoothly, you'll need to install the Epic Games Launcher (for Unreal Engine 5.3.2) and JetBrains Rider IDE. It's crucial to avoid opening this application in CLion as it may lead to operational inconsistencies. Additionally, it's worth noting that specific code segments in this project aren't designed for compilation within an IDE. However, they are optimized for successful compilation within the Unreal Engine Editor.

The source code for building the models and visualizations from biological data can be found in this [repository](https://github.com/annika6246/BioExploration). This code was stored separately since it has a cmake configuration, which is not compatible with Rider IDE but is for one such as CLion. This program does not require any command line elements to run as the data used is already included in the repository, and the driver can be modified to take different input files. Running this program requires both the MLPack and SeqAn libraries to be installed as well as their dependencies (which include armadillo, ensmallen, and cereal).

## Links to external libraries
MLPack: github.com/mlpack
SeqAn (version 2.4: github.com/seqan
