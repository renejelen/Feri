#!/bin/bash

seznam="predmeti.txt"


mkdir -p studij


while read -r line 
do
   mkdir -p "studij/$line"
   mkdir -p "studij/$line/{vaje,predavanja}"
done < "$seznam"
