#!/bin/bash

# GitHub URL, kjer se nahaja datoteka z imeni predmetov
GITHUB_URL="https://raw.githubusercontent.com/renejelen/Feri/main/predmeti?token=GHSAT0AAAAAACKB2IXPPUP43AZO5QE5K3HQZKL7FNA"

# Ime glavne mape
MAIN_DIR="studij"

# SSH uporabniško ime in naslov strežnika
SSH_USER="renejelen"
SSH_HOST="renejelen"

# Preverite, ali obstaja glavna mapa in jo izbrišite, če obstaja
if ssh "$SSH_USER@$SSH_HOST" "[ -d $MAIN_DIR ]"; then
    ssh "$SSH_USER@$SSH_HOST" "rm -r $MAIN_DIR"
fi

# Ustvarite glavno mapo
ssh "$SSH_USER@$SSH_HOST" "mkdir $MAIN_DIR"
ssh "$SSH_USER@$SSH_HOST" "cd $MAIN_DIR"

# Prenesite datoteko z imeni predmetov iz GitHub
ssh "$SSH_USER@$SSH_HOST" "curl -o predmeti.txt $GITHUB_URL"

# Preberite datoteko in ustvarite mape za vsak predmet
while IFS= read -r subject
do
    ssh "$SSH_USER@$SSH_HOST" "mkdir -p 2023-24/$subject/vaje"
    ssh "$SSH_USER@$SSH_HOST" "mkdir -p 2023-24/$subject/predavanja"
done < predmeti.txt

# Izpišite drevesno strukturo novo ustvarjenih map
ssh "$SSH_USER@$SSH_HOST" "tree $MAIN_DIR"

# Počistite začasne datoteke, če želite
ssh "$SSH_USER@$SSH_HOST" "rm predmeti.txt"