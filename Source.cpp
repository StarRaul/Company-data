#pragma once
#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
#include <fstream>
#include "Source.h"
using namespace std;

void SaveToFile() {
    ofstream out(DATA_FILE);
    if (!out) {
        cout << "Error opening file for writing!" << endl;
        return;
        }
    for (auto it = Employee.begin(); it != Employee.end(); ++it) {
        (*it)->saveToFile(out);
        }
    out.close();
    }

double stringToDouble(const char* str) {
    double result = 0.0;
    double factor = 1.0;
    bool decimal = false;
    bool negative = false;
    if (*str == '-') {
        negative = true;
        str++;
        }
    for (; *str; ++str) {
        if (*str == '.') {
            decimal = true;
            continue;
            }
        int digit = *str - '0';
        if (digit >= 0 && digit <= 9) {
            if (decimal) {
                factor /= 10.0;
                result += digit * factor;
                } else {
                result = result * 10.0 + digit;
                }
            }
        }
    return negative ? -result : result;
    }

void initializeCompanyData() { // This is where all the magic happens
    ofstream clearFile(DATA_FILE, ios::trunc);
    clearFile.close();

    // The CEO (the one and only)
    CEO* ceo = new CEO("Casey Hartman", 25000);
    Employee.add(ceo);

    // Manage Department Leaders
    // DepartmentLeader* X = new DepartmentLeader("Name", salary, "Department", "Function");
    DepartmentLeader* itLeader = new DepartmentLeader("Cameron Shah", 15000, "IT", "Final check after Team Leaders");
    DepartmentLeader* hrLeader = new DepartmentLeader("Mikayla Schmidt", 14000, "HR", "Manage salaries and payments");


    // And add them to the list
    // Employee.add(X);
    Employee.add(itLeader);
    Employee.add(hrLeader);


    // Manage Team Leaders
    // TeamLeader* X = new TeamLeader("Name", salary, "Department", "Function");
    TeamLeader* devLead = new TeamLeader("Karter Duke", 12000, "IT", "Check for bugs in the system");
    TeamLeader* qaLead = new TeamLeader("Helena Barron", 11000, "HR", "Distribute resources");


    // And add them to the list
    // Employee.add(X);
    Employee.add(devLead);
    Employee.add(qaLead);


    // Manage Workers
    // Worker* X = new Worker("Name", salary, "Department", "Function");
    Worker* dev1 = new Worker("Angel Tapia", 9000, "IT", "Manage the company's hierarchy");
    Worker* dev2 = new Worker("Thea Cohen", 8500, "IT", "Manage the teams");
    Worker* qa1 = new Worker("Eva Mueller", 8000, "HR", "Quality assurance");

    // And add them to the list
    // Employee.add(X);
    Employee.add(dev1);
    Employee.add(dev2);
    Employee.add(qa1);


    // Build relationships
    // X->addSubordinate(Y);
    // X->removeSubordinate(Y);
    ceo->addSubordinate(itLeader);
    ceo->addSubordinate(hrLeader);
    itLeader->addSubordinate(devLead);
    itLeader->addSubordinate(qaLead);
    devLead->addSubordinate(dev1);
    devLead->addSubordinate(dev2);
    qaLead->addSubordinate(qa1);


    // Manage tasks
    // X->addTask(Y);
    // X->removeTask(Y);
    ceo->addTask(new Task("Set company vision", Task::withBudget, "", 50000));
    itLeader->addTask(new Task("Upgrade infrastructure", Task::withBudget, "", 10000));
    devLead->addTask(new Task("Develop new feature", Task::withBoth, "29/09/2025", 7000));
    dev1->addTask(new Task("Implement API", Task::withDeadline, "20/12/2025", 0));
    qa1->addTask(new Task("Test system", Task::withDeadline, "10/02/2026", 0));


    // Save to file
    SaveToFile();
    }

int main() {
    ifstream testFile(DATA_FILE);
    bool fileExists = testFile.good();
    bool fileEmpty = true;
    if (fileExists) {
        testFile.seekg(0, ios::end);
        fileEmpty = testFile.tellg() == 0;
        testFile.close();
        }

    if (!fileExists || fileEmpty) { initializeCompanyData(); } else { initializeCompanyData(); }

    cout << "============== COMPANY STRUCTURE =============" << endl;
    for (auto it = Employee.begin(); it != Employee.end(); ++it) {
        (*it)->display();
        cout << "----------------------------------------------" << endl;
        }
    for (auto it = Employee.begin(); it != Employee.end(); ++it) {
        delete* it;
        }
    return 0;
    }