import turtle as t
import math as m


class Screen: #class screen initialises how the screen will appear, and where the pattern appears in relation to this
    def __init__(self, x, y): #constructor
        self.x, self.y = x / 2, y / 2 #set the x and y to roughly the centre of the screen
        self.xscreen, self.yscreen = x, y #the actual size of the screen
        t.setup(self.xscreen, self.yscreen) #setup turtle screen
        t.clear() #clear everything on it, in case it is running for a second time
        t.penup() #pen up as to not draw on the screen
        t.setpos(-self.xscreen / 4, self.yscreen / 4) #set the pos to the centre
        t.pendown() #pen down
        t.speed("fastest") #set speed to fastest!

class Interpreter: #the interpreter class reads and presents the sizing helper template file type. this is called very often
    def __init__(self): #most of these initial will be modified by they are the defaults
        self.x, self.y = 0, 0 #set relative coordinates to 0, 0
        self.scale_factor = 1 #set a default scale factor
        self.fabric_area = {} #start a dict called fabric area
        self.seamed_fabric_area = {} #start a dict called seamed fabric area
        self.prevcolor = "black" #set the previous color to black to display text
        self.pen = True #set the pen to true
        self.sa = 2 #set the seam allowance to 1
        self.show_angles = True #set the show angles to true
        self.radian_mode = False #set the radian mode to false

        screen = Screen(800, 600) #create a new screen class of that size

    def write_alt(self, text, angle=False): #defines a new write method
        text1 = text #assign text parameter to a local variable so we can edit it
        if isinstance(text, float): #if its a float
            text1 = float(round(text, 1)) #round it to one dp
        t.color("black") #set the colour of the text to black
        if angle and self.show_angles: #if we are showing the angle
            text1 = float(text1) #turn this into a float
            if self.radian_mode: #if its in radian mode
                text1 *= float(3.14/180) #convert to radian
                text1 = round(text1, 2)
                t.write(str(text1) + "r") #write as a radian on the turtle window
            else:
                t.write(str(text1) + "°") #write as a degree on the turtle window
        else:
            t.write(text1 + self.sa) #just write
        t.color(self.prevcolor) #reset color to the default

    def forward_alt(self, length): #
        length = round(length, 1)  # round the length to one decimal place
        if self.display_lengths: #if display lengths it true (will always be true)
            t.forward((length)) #move forward by default amount
            self.write_alt(length * self.scale_factor, angle=False) #write the text
            t.forward((length)) #move forward by default amount
        else:
            t.forward(length * 2) #if there is not writing move forward by twice the default amount instead
        self.x, self.y = t.position() #make sure to record the x, y position!

    def angle_alt(self, angle):
        t.right(int(angle))
        if self.display_angles:
            self.write_alt(text=angle, angle=True)

    def interpret_main(
        self,
        path,
        scale_factor=1,
        color_scale_factor=1,
        display_angles=True,
        display_lengths=True,
        radian_mode=False
    ):
        t.tracer(0, 0)
        self.display_lengths = True if display_lengths else False
        self.display_angles = True if display_angles else False
        self.scale_factor = scale_factor
        self.color_scale_factor = color_scale_factor
        fabric_area = {}
        seamed_fabric_area = {}
        with open(path) as f:
            self.prevcolor = "black"
            for line in f:
                items = line.rstrip(",\n").split(",")
                if len(items) > 1 and items[0] != ("RTN" or "LTN"):
                    try:
                        items[1] = float(items[1])
                        if items[0] == "NLN":
                            items[2] = float(items[2])
                    except:
                        pass
                if items[0] == "RTN":
                    self.angle_alt(int(items[1]))
                elif items[0] == "LTN":
                    self.angle_alt(-int(items[1]))
                elif items[0] == "FWD":
                    self.forward_alt(int(items[1]))
                elif items[0] == "BKD":
                    self.forward_alt(-int(items[1]))
                elif items[0] == "LCL":
                    if items[1] not in self.fabric_area:
                        self.fabric_area[items[1]] = 0
                    self.prevcolor = items[1]
                    t.color(items[1])
                elif items[0] == "SFL":
                    if items[1] not in self.fabric_area:
                        self.fabric_area[items[1]] = 0
                    self.prevcolor = items[1]
                    t.begin_fill()
                elif items[0] == "EFL":
                    t.end_fill()
                elif items[0] == "PNU":
                    self.pen = False
                    t.penup()
                elif items[0] == "PND":
                    self.pen = True
                    t.pendown()
                elif items[0] == "PNS":
                    t.pensize(int(items[1]))
                elif items[0] == "SQR":
                    if len(items) == 3:
                        if items[2] not in self.fabric_area:
                            self.fabric_area[items[2]] = 0
                            self.seamed_fabric_area[items[2]] = 0
                        t.color(items[2])
                        self.prevcolor = items[2]
                        t.begin_fill()
                    for i in range(4):
                        self.forward_alt(int(items[1]))
                        self.angle_alt(90)
                    if len(items) == 3:
                        t.end_fill()
                        self.fabric_area[items[2]] += (
                            items[1] * self.scale_factor
                        ) ** 2
                        self.seamed_fabric_area[items[2]] += (
                            (items[1] * self.scale_factor) + self.sa
                        ) ** 2
                elif items[0] == "HST":  # square halved into two triangles
                    hyp = m.hypot(items[1], items[1])
                    seamed_hyp = m.hypot(items[1] + self.sa, items[1] + self.sa)
                    if items[2] == "True":
                        t.penup()
                        t.forward(int(items[1] * 2))
                        t.right(90)
                        t.pendown()

                    if len(items) >= 4:
                        if items[3] not in self.fabric_area:
                            self.fabric_area[items[3]] = 0
                            self.seamed_fabric_area[items[3]] = 0
                        t.color(items[3])
                        self.prevcolor = items[3]
                        t.begin_fill()

                    self.angle_alt(45)
                    self.forward_alt(hyp)
                    t.right(135)
                    if self.display_angles:
                        self.write_alt("45", True)
                    self.forward_alt(int(items[1]))
                    self.angle_alt(90)
                    self.forward_alt(int(items[1]))
                    t.right(90)
                    if len(items) >= 4:
                        t.end_fill()
                        self.fabric_area[items[3]] += (
                            (items[1] * self.scale_factor) ** 2
                        ) / 2
                        self.seamed_fabric_area[items[3]] += (
                            ((items[1] * self.scale_factor) + self.sa) ** 2
                        ) / 2

                    if len(items) == 5:
                        if items[4] not in self.fabric_area:
                            self.fabric_area[items[4]] = 0
                            self.seamed_fabric_area[items[4]] = 0
                        t.color(items[4])
                        self.prevcolor = items[4]
                        t.begin_fill()
                    self.forward_alt(int(items[1]))
                    self.angle_alt(90)
                    self.forward_alt(int(items[1]))
                    t.right(135)
                    if self.display_angles:
                        self.write_alt("45", True)
                    self.forward_alt(hyp)

                    if len(items) == 5:
                        t.end_fill()
                        self.fabric_area[items[4]] += (
                            items[1] * self.scale_factor
                        ) ** 2
                        self.seamed_fabric_area[items[4]] += (
                            ((items[1] * self.scale_factor) + self.sa) ** 2
                        ) / 2

                    if items[2] == "True":
                        t.penup()
                        t.right(45)
                        t.backward(int(items[1]) * 2)
                        t.pendown()
                    else:
                        t.right(135)
                elif items[0] == "SKP":  # skip to next square
                    t.penup()
                    t.forward(float(items[1]) * 2)
                    t.pendown()
                elif items[0] == "NLN":  # New line of square units
                    t.penup()
                    t.backward(int(items[1]) * 2)
                    t.right(90)
                    t.forward(int(items[2]) * 2)
                    t.left(90)
                    t.pendown()
                else:
                    print("WARNING: Command ", items[0], " is not recognised. File may not draw correctly.")


class GUI_Interface:
    def __init__(
        self, path, areas, sa, show_angles, radian_mode, scale_factor=1, repeats=1
    ):
        self.path = path
        self.areas = areas
        self.areas_array = [[key, value] for key, value in areas.items()]
        self.sa = sa
        self.show_angles = show_angles
        self.radian_mode = radian_mode
        self.scale_factor = scale_factor
        self.repeats = repeats
        self.seamed_pattern_areas = []
        self.pattern_areas = []

    def area_solve(self):
        interpreter = Interpreter()
        interpreter.sa = self.sa
        interpreter.show_angles = self.show_angles
        interpreter.radian_mode = self.radian_mode
        interpreter.interpret_main(path=self.path, display_lengths=True, display_angles=self.show_angles)
        seamed_pattern_areas = [[key, value] for key, value in interpreter.seamed_fabric_area.items()]

        self.seamed_pattern_areas = seamed_pattern_areas
        def solve(areas_fabric, areas_pattern):
            areas_differences = []
            for fabric, pattern in zip(areas_fabric, areas_pattern):
                areas_differences.append(float(pattern[1]) - float(fabric[1]))

            min_item = max(areas_differences)
            min_index = areas_differences.index(min_item)

            print("Areas of the pattern: ", areas_pattern)
            print("Areas of your fabric: ",areas_fabric)

            # Find the scale factor that makes the total pattern area equal to the total fabric area
            print("Scale Factor calculation: ",str(areas_fabric[min_index][1])+" / "+str(areas_pattern[min_index][1]))
            optimal_sf = (float(areas_fabric[min_index][1]) / float(areas_pattern[min_index][1])) *0.8
            print("Scaling by a scale factor of "+str(optimal_sf))
            scaled = Interpreter()
            scaled.interpret_main(path=self.path, display_lengths=True, scale_factor=optimal_sf)
            scaled_pattern_areas = [[key, value] for key, value in scaled.seamed_fabric_area.items()]
            print("Areas of fabric you have to complete the pattern with these lengths: ",scaled_pattern_areas)
            fabric_repeats = scaled_pattern_areas
            for i in range(len(fabric_repeats)):
                fabric_repeats[i][1] *= int(self.repeats)
            print("Areas of fabric that you have to buy in total to repeat the fabric: ", fabric_repeats)

            return optimal_sf

        solve(self.areas_array, self.seamed_pattern_areas)


def area_function(path, areas, sa, show_angles, radian_mode, scale_factor=1, repeats=1):  # to be called from GUI app
    GUI = GUI_Interface(path, areas, sa, show_angles, radian_mode, scale_factor, repeats)
    GUI.area_solve()
    t.exitonclick()


def scale_factor_function(path, sf, sa, show_angles, radian_mode, repeats):  # to be called from GUI app
    interpreter = Interpreter()
    interpreter.scale_factor = sf
    interpreter.radian_mode = radian_mode
    interpreter.interpret_main(path, sf, sa, show_angles, radian_mode=radian_mode)
    print("Areas of fabric you need: ", interpreter.seamed_fabric_area)
    fabric_repeats = [[key, value] for key, value in interpreter.seamed_fabric_area.items()]
    for i in range(len(fabric_repeats)):
        fabric_repeats[i][1] *= int(repeats)
    print("Areas of fabric that you have to buy in total to repeat the fabric: ", fabric_repeats)
    t.exitonclick()
