import sys
from datetime import datetime

Start = 1

while Start:
    OneCase = str(input("\nThis is an interactive terminal for tren programm: "))
    if OneCase == "--info":
        print("\nversion -- 0.0.0 (Beta) \n \ndata launch --", datetime.now())

    elif OneCase == "/exit":
        sys.exit()

    elif OneCase == "--help":
        print("\n--info === information about the program")
        print("\n/exite === close programm")
    
    else:
        print("\nerror: --", OneCase, "-- is not an internal command!")
    