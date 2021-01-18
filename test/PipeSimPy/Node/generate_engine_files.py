'''
    PIPESIM Python Toolkit
    Example: Export engine files

'''
print("Running example file '{}'".format(__file__))

from sixgill.pipesim import Model
import os
import tempfile

filename =  os.path.join(os.path.dirname(__file__), "Node",  "Node.pips")
print("Opening model '{}'".format(filename))
model = Model.open(filename)

# Export network simulation files to current pipesim file folder
files = model.tasks.networksimulation.generate_engine_files(study="Study 1", folder_path='Node')
print("The exported network simulation files are:")
print(files)

files = model.tasks.ptprofilesimulation.generate_engine_files(producer="Src 2", study="Study 1", folder_path='Node')
print("The exported P/T profile simulation files are:")
print(files)

model.close()

input("Press enter to continue...")