print("The KillSmoke shows the number of days without cigarettes.")

day_without_smoking = Load()
answer = input("Did you smoke today?y/n")

if(answer == 'y'):
    day_without_smoking = 0

Save(day_without_smoking)

def Load():
    return 

def Save(day_without_smoking):
    pass