#!/bin/bash
# Bash Menu Script Example

PS3='Escolha uma opcao: '
options=("Questao 1" "Questao 2" "Questao 3" "Questao 4" "Questao 5" "Sair")
select opt in "${options[@]}"
do
    case $opt in
        "Questao 1")
            cd question1/app && dotnet run && cd ../..
            ;;
        "Questao 2")
            cd question2/app && dotnet run && cd ../..
            ;;
        "Questao 3")
            cd question3/app && dotnet run && cd ../..
            ;;
        "Questao 4")
            cd question4/app && dotnet run && cd ../..
            ;;
        "Questao 5")
            cd question5/app && dotnet run && cd ../..
            ;;
        "Sair")
            echo "Saindo..."
            break
            ;;
        *) echo "Opcao invalida (escolha apenas numeros) $REPLY";;
    esac
done