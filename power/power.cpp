#include <iostream>

int main() {

    int num;
    std::cout << "Enter the number you want to find the power of: ";
    std:: cin >> num;
    int Num = num;

    int power;
    std::cout << "Enter the power that you want to find: ";
    std::cin >> power;

    for (int i = 1; i <= power - 1; i ++) Num *= num;

    std::cout << num << " ^ " << power << " is " << Num;

    return 0;

}