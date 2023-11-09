#!/bin/bash

base_directory="studij"
academic_year="2023-24"

while read -r line
do
   mkdir -p "$base_directory/$academic_year/$line/vaje"
   mkdir -p "$base_directory/$academic_year/$line/predavanja"
done < "predmeti.txt"
