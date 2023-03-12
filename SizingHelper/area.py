import main

areas = {}
path = ""
sf = 0
sa = 0
show_angles = True
show_radians = False
repeats = 1

with open("params.cfg") as pf, open("areas.txt") as af:
    for line in af:
        if line != '':
            key, value = line.strip().split(',')
            areas[key.strip()] = value.strip()
    path = pf.readline().strip()
    sf = float(pf.readline().strip())
    sa = float(pf.readline().strip())
    show_angles = (pf.readline().strip() == "True")
    show_radians = (pf.readline().strip() == "True")
    repeats = (pf.readline().strip())

    print("path:", path)
    print("sf:", sf)
    print("sa:", sa)
    print("show_angles:", show_angles)
    print("show_radians:", show_radians)
    print("repeats: ", repeats)

main.area_function(path, areas, sa, show_angles, show_radians, sf, repeats)