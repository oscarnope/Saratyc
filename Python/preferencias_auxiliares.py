#!/usr/bin/env python
# coding: utf-8

# # Trabajo de Grado
# 
# Similitud de Preferencias Multidimensional
# 
# Universidad Javeriana  
# August, 2022  
#   
# Dataset: 
# Preferencias Auxiliares Médicos
# Preferencias Pacientes
# 

# In[5]:


# Importing libraries

import numpy as np
import pandas as pd
from datetime import datetime

import matplotlib.pyplot as plt
import seaborn as sns

from pandas_profiling import ProfileReport

#%matplotlib inline


# In[6]:


# Panadas configuration for extending the number of rows and columns to visualize, if not limit set parameter to None or -1
pd.set_option('display.max_rows', 100)
pd.set_option('display.max_columns', 100)


# In[66]:


# Loading las Preferencias de los Auxiliares CSV file as dataframe, showing first rows
pref_aux_df = pd.read_csv('data/Datos_Preferencias_Aux.csv',sep=";",header= 0)


# In[67]:


# Showing first rows
pref_aux_df.head()


# ### Analizing data quality

# In[9]:


pref_aux_df.dtypes


# In[10]:


##Filtra por Tipo de Compania Pref, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['Id', 'Tipo de compania Pref']]
pref_aux_df_filtro_df.head()

pref_aux_df_filtro_df.set_index(['Id','Tipo de compania Pref'])
TipoCompPref_df = pref_aux_df_filtro_df.pivot(index=['Id'], columns="Tipo de compania Pref", values="Id")
TipoCompPref_df = TipoCompPref_df.fillna(0)
TipoCompPref_df[TipoCompPref_df != 0] = 1 
TipoCompPref_df.head()


# In[11]:


##Filtra por Tipo de Turno Pref, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['Id', 'Turno pref']]
pref_aux_df_filtro_df.head()

pref_aux_df_filtro_df.set_index(['Id','Turno pref'])
TurnoPref_df = pref_aux_df_filtro_df.pivot(index=['Id'], columns="Turno pref", values="Id")
TurnoPref_df = TurnoPref_df.fillna(0)
TurnoPref_df[TurnoPref_df != 0] = 1 
TurnoPref_df.head()


# In[12]:


##Filtra por Tipo de Servicios Pref, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['Id', 'Tipo Servicios Pref']]
pref_aux_df_filtro_df.head()

pref_aux_df_filtro_df.set_index(['Id','Tipo Servicios Pref'])
TipoServiciosPref_df = pref_aux_df_filtro_df.pivot(index=['Id'], columns="Tipo Servicios Pref", values="Id")
TipoServiciosPref_df = TipoServiciosPref_df.fillna(0)
TipoServiciosPref_df[TipoServiciosPref_df != 0] = 1 
TipoServiciosPref_df.head()


# In[68]:


##Filtra por Temperamento Pref, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
##Temperamento de preferencia del auxiliar se puede filtrar los que tienen prioridad >= 3 
##Tocaría llenar la variable Temperamento Pref de los auxiliares para poder encontrar las preferencias.

pref_aux_df_filtro_df = pref_aux_df[['Id', 'Temperamento Pref']]
pref_aux_df_filtro_df.head()

pref_aux_df_filtro_df.set_index(['Id','Temperamento Pref'])
TemperamentoPref_df = pref_aux_df_filtro_df.pivot(index=['Id'], columns="Temperamento Pref", values="Id")
TemperamentoPref_df = TemperamentoPref_df.fillna(0)
TemperamentoPref_df[TemperamentoPref_df != 0] = 1 
TemperamentoPref_df.head()


# In[14]:


##Filtra por Remuneración Pref , Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['Id', 'Remuneración Pref']]
pref_aux_df_filtro_df.head()

pref_aux_df_filtro_df.set_index(['Id','Remuneración Pref'])
RemuneracionPref_df = pref_aux_df_filtro_df.pivot(index=['Id'], columns="Remuneración Pref", values="Id")
RemuneracionPref_df = RemuneracionPref_df.fillna(0)
RemuneracionPref_df[RemuneracionPref_df != 0] = 1 
RemuneracionPref_df.head()


# In[15]:


##Filtra por Remuneración Pref , Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['Id', 'Binomio madre recién nacido Pref']]
pref_aux_df_filtro_df.head()

pref_aux_df_filtro_df.set_index(['Id','Binomio madre recién nacido Pref'])
BinomioPref_df = pref_aux_df_filtro_df.pivot(index=['Id'], columns="Binomio madre recién nacido Pref", values="Id")
BinomioPref_df = BinomioPref_df.fillna(0)
BinomioPref_df[BinomioPref_df != 0] = 1 
BinomioPref_df.head()


# In[16]:


##Filtra por Remuneración Pref , Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['Id', 'Niños Pref']]
pref_aux_df_filtro_df.head()

pref_aux_df_filtro_df.set_index(['Id','Niños Pref'])
NiñosPref_df = pref_aux_df_filtro_df.pivot(index=['Id'], columns="Niños Pref", values="Id")
NiñosPref_df = NiñosPref_df.fillna(0)
NiñosPref_df[NiñosPref_df != 0] = 1 
NiñosPref_df.head()


# In[17]:


##Filtra por Remuneración Pref , Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['Id', 'Adultos mayores Pref']]
pref_aux_df_filtro_df.head()

pref_aux_df_filtro_df.set_index(['Id','Adultos mayores Pref'])
AdultosPref_df = pref_aux_df_filtro_df.pivot(index=['Id'], columns="Adultos mayores Pref", values="Id")
AdultosPref_df = AdultosPref_df.fillna(0)
AdultosPref_df[AdultosPref_df != 0] = 1 
AdultosPref_df.head()


# In[18]:


##Filtra por Experiencia, Normaliza los datos : Cambia los valores No a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['Id', 'Catéter Periférico Exp', 'Colostomía Exp', 'Discapacidad auditiva Exp','Drenes Exp','Glucometría Exp','Medicación aplicación endovenosa Exp','Nefrostomia Exp','Oxigeno Exp','Sonda Gastrostomía Exp','Sonda Naso gástrica Exp','Sonda Orogástrica Exp','Sonda Vesical Exp','Traqueostomía Exp','Postcirugía estética Exp']]
pref_aux_df_filtro_df.head()

pref_aux_df_filtro_df.set_index(['Id'])
Experiencia_df = pref_aux_df_filtro_df
Experiencia_df = Experiencia_df.replace("Si",1)
Experiencia_df = Experiencia_df.replace("No",0)
Experiencia_df.head()


# In[71]:


##Filtra por Prioridad, Normaliza los datos : Cambia los valores a números entre 0 a 1, donde 1
##son los valores muy importante e importante, los demás quedan en 0
pref_aux_df_filtro_df = pref_aux_df[['Id' 
,'Sector de la ciudad Prioridad'                                          
,'Turno Prioridad'                                                        
,'Edad del paciente Prioridad'                                            
,'Tipo de transporte Prioridad'                                           
,'Numero de horas Prioridad'                                              
,'Genero del paciente Prioridad'                                          
,'Tiempo que le tomara desplazarse al sitio Prioridad'                    
,'Enfermedad que padezca Prioridad'                                       
,'Tipo de servicio Prioridad'                                             
,'Tipo de compañía Prioridad'                                             
,'Temperamento del paciente Prioridad'                                    
,'Horarios de estudio Prioridad'                                          
,'Horarios de compromisos personales Prioridad'                           
,'Nivel de conciencia del paciente  Prioridad'                            
,'Ayuda que necesite el paciente para realizar actividades Prioridad'     
,'Contextura física del paciente Prioridad'                               
]]
pref_aux_df_filtro_df.head()

pref_aux_df_filtro_df.set_index(['Id'])
Prioridad_df = pref_aux_df_filtro_df
Prioridad_df = Prioridad_df.replace("Muy Importante",1)
Prioridad_df = Prioridad_df.replace("Importante",1)
Prioridad_df = Prioridad_df.replace("Poco importante",0)
Prioridad_df = Prioridad_df.replace("Nada importante",0)
Prioridad_df.head()


# In[20]:


# Loading los datos de los pacientes CSV file as dataframe, showing first rows
dat_pac_df = pd.read_csv('data/Datos_Preferencias_Pacientes.csv',sep=";",header= 0)


# In[21]:


# Showing first rows
dat_pac_df.head()


# In[22]:


##Filtra por Turno Paciente, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pac_df_filtro_df = dat_pac_df[['Id', 'Turno']]
pac_df_filtro_df.head()

pac_df_filtro_df.set_index(['Id','Turno'])
TurnoPac_df = pac_df_filtro_df.pivot(index=['Id'], columns="Turno", values="Id")
TurnoPac_df = TurnoPac_df.fillna(0)
TurnoPac_df[TurnoPac_df != 0] = 1 
TurnoPac_df.head()


# In[23]:


##Filtra por Tipo de Compania Paciente, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pac_df_filtro_df = dat_pac_df[['Id', 'Tipo de compania']]
pac_df_filtro_df.head()

pac_df_filtro_df.set_index(['Id','Tipo de compania'])
TipoCompPac_df = pac_df_filtro_df.pivot(index=['Id'], columns="Tipo de compania", values="Id")
TipoCompPac_df = TipoCompPac_df.fillna(0)
TipoCompPac_df[TipoCompPac_df != 0] = 1 
TipoCompPac_df.head()


# In[24]:


##Filtra por Institución Paciente, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pac_df_filtro_df = dat_pac_df[['Id', 'Institucion']]
pac_df_filtro_df.head()

pac_df_filtro_df.set_index(['Id','Institucion'])
InstitucionPac_df = pac_df_filtro_df.pivot(index=['Id'], columns="Institucion", values="Id")
InstitucionPac_df = InstitucionPac_df.fillna(0)
InstitucionPac_df[InstitucionPac_df != 0] = 1 
InstitucionPac_df.head()


# In[25]:


##Filtra por Institución Paciente, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pac_df_filtro_df = dat_pac_df[['Id', 'Condicion de Salud']]
pac_df_filtro_df.head()

pac_df_filtro_df.set_index(['Id','Condicion de Salud'])
CondicionSaludPac_df = pac_df_filtro_df.pivot(index=['Id'], columns="Condicion de Salud", values="Id")
CondicionSaludPac_df = CondicionSaludPac_df.fillna(0)
CondicionSaludPac_df[CondicionSaludPac_df != 0] = 1 
CondicionSaludPac_df.head()


# In[26]:


##Filtra por Institución Paciente, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pac_df_filtro_df = dat_pac_df[['Id', 'Diagnostico']]
pac_df_filtro_df.head()

pac_df_filtro_df.set_index(['Id','Diagnostico'])
DiagnosticoPac_df = pac_df_filtro_df.pivot(index=['Id'], columns="Diagnostico", values="Id")
DiagnosticoPac_df = DiagnosticoPac_df.fillna(0)
DiagnosticoPac_df[DiagnosticoPac_df != 0] = 1 
DiagnosticoPac_df.head()


# In[27]:


##Filtra por Institución Paciente, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pac_df_filtro_df = dat_pac_df[['Id', 'Nivel de Conciencia']]
pac_df_filtro_df.head()

pac_df_filtro_df.set_index(['Id','Nivel de Conciencia'])
ConcienciaPac_df = pac_df_filtro_df.pivot(index=['Id'], columns="Nivel de Conciencia", values="Id")
ConcienciaPac_df = ConcienciaPac_df.fillna(0)
ConcienciaPac_df[ConcienciaPac_df != 0] = 1 
ConcienciaPac_df.head()


# In[28]:


##Filtra por Institución Paciente, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pac_df_filtro_df = dat_pac_df[['Id', 'Compania']]
pac_df_filtro_df.head()

pac_df_filtro_df.set_index(['Id','Compania'])
CompaniaPac_df = pac_df_filtro_df.pivot(index=['Id'], columns="Compania", values="Id")
CompaniaPac_df = CompaniaPac_df.fillna(0)
CompaniaPac_df[CompaniaPac_df != 0] = 1 
CompaniaPac_df.head()


# In[29]:


##Filtra por Institución Paciente, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pac_df_filtro_df = dat_pac_df[['Id', 'Nivel de Dependencia']]
pac_df_filtro_df.head()

pac_df_filtro_df.set_index(['Id','Nivel de Dependencia'])
NivelDependenciaPac_df = pac_df_filtro_df.pivot(index=['Id'], columns="Nivel de Dependencia", values="Id")
NivelDependenciaPac_df = NivelDependenciaPac_df.fillna(0)
NivelDependenciaPac_df[NivelDependenciaPac_df != 0] = 1 
NivelDependenciaPac_df.head()


# In[62]:


##Filtra por Institución Paciente, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pac_df_filtro_df = dat_pac_df[['Id', 'Temperamento']]
pac_df_filtro_df.head()

pac_df_filtro_df.set_index(['Id','Temperamento'])
TemperamentoPac_df = pac_df_filtro_df.pivot(index=['Id'], columns="Temperamento", values="Id")
TemperamentoPac_df = TemperamentoPac_df.fillna(0)
TemperamentoPac_df[TemperamentoPac_df != 0] = 1 
TemperamentoPac_df.head()


# In[31]:


#Implementación de la similaridad del coseno 
def SimilaridadCoseno(pacientePref, auxiliarPref):
    #inicializamos los sumatorios en 0
    sumxx, sumxy, sumyy = 0, 0, 0

    #cálculamos los sumatorios del númerador y el denominador
    for i in range(len(pacientePref)):
        x = pacientePref[i]
        y = auxiliarPref[i]
        sumxx += x*x
        sumyy += y*y
        sumxy += x*y
    
    #Simplificamos la ecuación, ahorrandonos hacer dos raices cuadradas, para que sea más rápido
    return sumxy/np.sqrt((sumxx*sumyy))


# In[32]:


df1=TipoCompPac_df.reset_index()
df2=TipoCompPref_df.reset_index()
df1.head()


# In[33]:


df2.head()


# In[34]:


#Encontrar auxiliares similares con las preferencias de los pacientes.
df1=TipoCompPac_df.reset_index()
df2=TipoCompPref_df.reset_index()

SimilaridadCoseno(df1.loc[0].values, df2.loc[0].values)


# In[35]:


#Datos del Paciente 1
df1.loc[0].values


# In[36]:


#Preferencias del Auxiliar 1
df2.loc[0].values


# In[37]:


SimilaridadCoseno(df1.loc[0].values, df2.loc[1].values)


# In[38]:


SimilaridadCoseno(df1.loc[0].values, df2.loc[2].values)


# In[39]:


#TipoCompPac_df
#TipoCompPref_df
#Compañia del Paciente
df1=TipoCompPac_df.reset_index()
df2=TipoCompPref_df.reset_index()
rec_Pac_df = pd.DataFrame()
df = pd.DataFrame(columns=['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14'
                          ,'15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28'
                          , '29', '30', '31', '32'],
                  index=range(32))

#df_New = pd.DataFrame()
df_New = pd.DataFrame(columns=[],
                  index=range(1))
#print(len(TipoCompPac_df))
#print(len(TipoCompPref_df))

for idPaciente in range(len(TipoCompPac_df)):
    #print("Paciente", idPaciente)
    ls_dataSimilar = []
    for idAuxiliar in range(len(TipoCompPref_df)):
        ls_dataSimilar.append(SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        #df_New[idAuxiliar] = pd.DataFrame(ls_dataSimilar)
        df_New[idAuxiliar] = (SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        
    
    rec_Pac_df = rec_Pac_df.append(df_New, ignore_index=True)


rec_Pac_df.head(20)


# In[40]:


#TurnoPref_df
#TurnoPac_df
#Turno del Paciente
df1=TurnoPac_df.reset_index()
df2=TurnoPref_df.reset_index()
recTurno_Pac_df = pd.DataFrame()
df = pd.DataFrame(columns=['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14'
                          ,'15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28'
                          , '29', '30', '31', '32'],
                  index=range(32))

df_New = pd.DataFrame(columns=[],
                  index=range(1))

for idPaciente in range(len(df1)):
    ls_dataSimilar = []
    for idAuxiliar in range(len(df2)):
        ls_dataSimilar.append(SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        df_New[idAuxiliar] = (SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        
    
    recTurno_Pac_df = recTurno_Pac_df.append(df_New, ignore_index=True)


recTurno_Pac_df.head(20)


# In[46]:


#TipoServiciosPref_df
#InstitucionPac_df
#Turno del Paciente
df1=InstitucionPac_df.reset_index()
df2=TipoServiciosPref_df.reset_index()
recInstitucion_Pac_df = pd.DataFrame()
df = pd.DataFrame(columns=['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14'
                          ,'15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28'
                          , '29', '30', '31', '32'],
                  index=range(32))

df_New = pd.DataFrame(columns=[],
                  index=range(1))

for idPaciente in range(len(df1)):
    ls_dataSimilar = []
    for idAuxiliar in range(len(df2)):
        ls_dataSimilar.append(SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        df_New[idAuxiliar] = (SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        
    
    recInstitucion_Pac_df = recInstitucion_Pac_df.append(df_New, ignore_index=True)


recInstitucion_Pac_df.head(20)


# In[69]:


#TemperamentoPref_df
#TemperamentoPac_df
#Temperamento del Paciente
df1=TemperamentoPac_df.reset_index()
df2=TemperamentoPref_df.reset_index()
recTemperamento_Pac_df = pd.DataFrame()
df = pd.DataFrame(columns=['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14'
                          ,'15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28'
                          , '29', '30', '31', '32'],
                  index=range(32))

df_New = pd.DataFrame(columns=[],
                  index=range(1))

for idPaciente in range(len(df1)):
    ls_dataSimilar = []
    for idAuxiliar in range(len(df2)):
        ls_dataSimilar.append(SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        df_New[idAuxiliar] = (SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        
    
    recTemperamento_Pac_df = recTemperamento_Pac_df.append(df_New, ignore_index=True)


recTemperamento_Pac_df.head(20)


# In[50]:


#Experiencia_df
#CondicionSaludPac_df
#Condición de salud del Paciente
df1=Experiencia_df.reset_index()
df2=CondicionSaludPac_df.reset_index()
recCondicionSalud_Pac_df = pd.DataFrame()
df = pd.DataFrame(columns=['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14'
                          ,'15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28'
                          , '29', '30', '31', '32'],
                  index=range(32))

df_New = pd.DataFrame(columns=[],
                  index=range(1))

for idPaciente in range(len(df1)):
    ls_dataSimilar = []
    for idAuxiliar in range(len(df2)):
        ls_dataSimilar.append(SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        df_New[idAuxiliar] = (SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        
    
    recCondicionSalud_Pac_df = recCondicionSalud_Pac_df.append(df_New, ignore_index=True)


recCondicionSalud_Pac_df.head(20)


# In[74]:


#Conciencia del Paciente 
#Este caso se crea un dataset con la columna del temperamento del paciente.
#Prioridad_df
#ConcienciaPac_df

df1=Prioridad_df['Temperamento del paciente Prioridad'].reset_index()
df2=ConcienciaPac_df.reset_index()
recConciencia_Pac_df = pd.DataFrame()
df = pd.DataFrame(columns=['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14'
                          ,'15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28'
                          , '29', '30', '31', '32'],
                  index=range(32))

df_New = pd.DataFrame(columns=[],
                  index=range(1))

for idPaciente in range(len(df1)):
    ls_dataSimilar = []
    for idAuxiliar in range(len(df2)):
        ls_dataSimilar.append(SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        df_New[idAuxiliar] = (SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        
    
    recConciencia_Pac_df = recConciencia_Pac_df.append(df_New, ignore_index=True)


recConciencia_Pac_df.head(20)


# In[ ]:


##Seleccionar todos los dataset de recomendaciones para promediar los valores de cada campo y luego de eso si se puede
##continuar con el ordenamiento de los valores para ordenar los auxiliares con mejor match.
##Acá se deben unir todas las celdas y dividir por la cantidad de datasets.


# In[41]:


#Para el paciente 0
#Se ordena los auxiliares con mayor coincidencia en el perfil del auxiliar con el del paciente
#Se pasa a una lista ordenada
array_Pac_df = rec_Pac_df.loc[0].values
array_Pac_df

recomendacion_Pac_df = pd.DataFrame()
recomendacion_Pac_df['Paciente_0'] = pd.DataFrame(array_Pac_df)
recomendacion_Pac_df.head()

recomendacion_Pac_df['Auxiliar'] = recomendacion_Pac_df.index 
recomendacion_Pac_df.reset_index()
resultado_df = recomendacion_Pac_df.sort_values("Paciente_0", ascending=False)
auxiliares_list = resultado_df["Auxiliar"].values.tolist()
print(auxiliares_list)


# In[42]:


#Para el paciente 0
#Se cambia la lista a filas, se guarda en un dataframe para luego guardarlo en una BD
resultado_Pac_df = pd.DataFrame()
df_New = pd.DataFrame(columns=[],
                  index=range(1))

resultado_Pac_df = pd.DataFrame([auxiliares_list])
resultado_Pac_df.append(resultado_Pac_df, ignore_index=True)
resultado_Pac_df.head()


# In[43]:


#Para todos los pacientes
#Se ordena los auxiliares con mayor coincidencia en el perfil del auxiliar con el del paciente
#Se pasa a una lista ordenada
resultado_Pac_df = pd.DataFrame()
recomendacion_Pac_df = pd.DataFrame()
resultado_df = pd.DataFrame()
resultado_aux_Pac_df = pd.DataFrame()

for idPaciente in range(len(rec_Pac_df)):
    array_Pac_df = rec_Pac_df.loc[idPaciente].values
    #print(array_Pac_df)
    recomendacion_Pac_df[idPaciente] = pd.DataFrame(array_Pac_df)
    recomendacion_Pac_df[idPaciente].head()
    recomendacion_Pac_df['Auxiliar'] = recomendacion_Pac_df.index 
    recomendacion_Pac_df.reset_index()
    pd.concat([recomendacion_Pac_df,pd.DataFrame(array_Pac_df)]) 
    resultado_df = recomendacion_Pac_df.sort_values(idPaciente, ascending=False)
    auxiliares_list = resultado_df["Auxiliar"].values.tolist()
    #print(auxiliares_list)
    resultado_aux_Pac_df = pd.DataFrame([auxiliares_list])
    #resultado_Pac_df = resultado_Pac_df.append(resultado_aux_Pac_df, ignore_index=True)
    resultado_Pac_df =  pd.concat([resultado_Pac_df,  resultado_aux_Pac_df])
   

    
resultado_Pac_df.head(10)


# In[44]:


resultado_Pac_df.to_csv('data/Recomendacion_Pacientes.csv',sep=";",header= 0)


# In[ ]:





# In[ ]:





# In[ ]:




