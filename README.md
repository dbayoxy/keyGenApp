# keyGenApp
Key generation from image features

The Lib folder contains the .dll created from Matlab
The dll was created because it was difficult accessing image processing toolbox funtionalities outside Matlab, so all the image processessing methods I created in Matlab are accessible via this dll

Grey Level Co-occurrence Matrix was used for extracting 
 contrast
 entropy
 uniformity
 homogeneity
 correlation
 
 Algorithm for key generation 
1.	Start 
2.	Reading the image into array
3.	Convert the image into a matrix [20, n]. n is number of column in the image matrix
4.	Specify the distance between neighbouring pixels, r.
5.	Specify the angle, D of the gray level co-occurrence matrix.
i.	If D = 900 then set offset = r*[-1 0]
ii.	If D =  450 then set offset = r*[-1 1]
iii.	If D = 1350 then set offset = r*[-1 –1]
iv.	If D = 00 then set offset = r*[0 1]
6.	Find the trace of the matrix (sum of the diagonal of the matrix)
7.	Compute other image descriptor values (Contrast, Correlation, Energy, Entropy, Homogeneity)  
8.	Set k = Trace * Contrast * Correlation * Energy *  Entropy * Homogeneity;
9.	Set count = location of decimal point and set GLCMKey=1.0;
10.	GLCMKey *= Math.Pow (10, count)
11.	Stop 
