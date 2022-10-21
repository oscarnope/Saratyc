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

# In[1]:


# Importing libraries

import numpy as np
import pandas as pd
from datetime import datetime, date 

import matplotlib.pyplot as plt
import seaborn as sns

from pandas_profiling import ProfileReport

#%matplotlib inline


# In[2]:


# Panadas configuration for extending the number of rows and columns to visualize, if not limit set parameter to None or -1
pd.set_option('display.max_rows', 100)
pd.set_option('display.max_columns', 100)


# In[3]:


# Loading las Preferencias de los Auxiliares CSV file as dataframe, showing first rows
pref_aux_df = pd.read_csv('data/Auxiliares3.0.csv',sep=";",header= 0, encoding='latin-1')


# In[4]:


# Showing first rows
pref_aux_df.head()


# ### Analizing data quality

# In[5]:


pref_aux_df.dtypes


# In[6]:


##Filtra por Experiencia, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['ID','EXPERIENCIAC1','EXPERIENCIAC2','EXPERIENCIAC3','EXPERIENCIAC4',
                                     'EXPERIENCIAC5','EXPERIENCIAD1','EXPERIENCIAD2','EXPERIENCIAD3',
                                      'EXPERIENCIAD4','EXPERIENCIAD5','EXPERIENCIAD6','EXPERIENCIAA1',
                                      'EXPERIENCIAA2','EXPERIENCIAA3','EXPERIENCIAA4','EXPERIENCIAA5',
                                      'EXPERIENCIAC6','EXPERIENCIAC7','EXPERIENCIAC8','EXPERIENCIAC9',
                                      'EXPERIENCIAC10','EXPERIENCIAC11','EXPERIENCIAC12','EXPERIENCIAC13',
                                      'EXPERIENCIAC14','EXPERIENCIACC1','EXPERIENCIACC2','EXPERIENCIACC3',
                                      'EXPERIENCIACC4','EXPERIENCIACC5'
                                    ]]
pref_aux_df_filtro_df.head()

ExperienciaPref_df = pref_aux_df_filtro_df
ExperienciaPref_df.rename(columns = {'EXPERIENCIAC1':'Catéter Periférico',
                                  'EXPERIENCIAC2':'Colostomía',
                                  'EXPERIENCIAC3':'Discapacidad auditiva',
                                  'EXPERIENCIAC4':'Discapacidad visual',
                                  'EXPERIENCIAC5':'Drenes',
                                  'EXPERIENCIAD1':'Medicina Interna',
                                  'EXPERIENCIAD2':'Quirúrgico',
                                  'EXPERIENCIAD3':'Oncológico',
                                  'EXPERIENCIAD4':'Psiquiátrico',
                                  'EXPERIENCIAD5':'Madre recién nacido',
                                  'EXPERIENCIAD6':'Neurológico',
                                  'EXPERIENCIAA1':'Paciente acompañado de familiar',
                                  'EXPERIENCIAA2':'Paciente sin compañía',
                                  'EXPERIENCIAA3':'Paciente acompañado de empleada',
                                  'EXPERIENCIAA4':'Toma de signos vitales',
                                  'EXPERIENCIAA5':'Seguridad del paciente',
                                  'EXPERIENCIAC6':'Glucometría',
                                  'EXPERIENCIAC7':'Medicación aplicación endovenosa',
                                  'EXPERIENCIAC8':'Nefrostomia',
                                  'EXPERIENCIAC9':'Oxigeno',
                                  'EXPERIENCIAC10':'Sonda Gastrostomía',
                                  'EXPERIENCIAC11':'Sonda Naso gástrica',
                                  'EXPERIENCIAC12':'Sonda Orogástrica',
                                  'EXPERIENCIAC13':'Sonda Vesical',
                                  'EXPERIENCIAC14':'Traqueostomía',
                                  'EXPERIENCIACC1':'Alerta/orientado',
                                  'EXPERIENCIACC2':'Comatoso',
                                  'EXPERIENCIACC3':'Confusión/desorientado',
                                  'EXPERIENCIACC4':'Estuporoso',
                                  'EXPERIENCIACC5':'Vegetativo'   
                                     
                                     
                                   }, inplace = True)
ExperienciaPref_df.head()

ExperienciaPref_df = ExperienciaPref_df.replace('SI',1)
ExperienciaPref_df = ExperienciaPref_df.replace('NO',0)


ExperienciaPref_df = ExperienciaPref_df.fillna(0)
#ExperienciaPref_df['ID'] = ExperienciaPref_df.index + 1
ExperienciaPref_df.head()


# In[7]:


##Filtra por Conocimiento, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['ID','CONOCIMIENTOC1','CONOCIMIENTOC2','CONOCIMIENTOC3','CONOCIMIENTOC4',
                                     'CONOCIMIENTOC5','CONOCIMIENTOD1','CONOCIMIENTOD2','CONOCIMIENTOD3',
                                      'CONOCIMIENTOD4','CONOCIMIENTOD5','CONOCIMIENTOD6','CONOCIMIENTOA1',
                                      'CONOCIMIENTOA2','CONOCIMIENTOA3','CONOCIMIENTOA4','CONOCIMIENTOA5',
                                      'CONOCIMIENTOC6','CONOCIMIENTOC7','CONOCIMIENTOC8','CONOCIMIENTOC9',
                                      'CONOCIMIENTOC10','CONOCIMIENTOC11','CONOCIMIENTOC12','CONOCIMIENTOC13',
                                      'CONOCIMIENTOC14','CONOCIMIENTOCC1','CONOCIMIENTOCC2','CONOCIMIENTOCC3',
                                      'CONOCIMIENTOCC4','CONOCIMIENTOCC5'
                                    ]]
pref_aux_df_filtro_df.head()

ConocimientoPref_df = pref_aux_df_filtro_df
ConocimientoPref_df.rename(columns = {'CONOCIMIENTOC1':'Catéter Periférico',
                                  'CONOCIMIENTOC2':'Colostomía',
                                  'CONOCIMIENTOC3':'Discapacidad auditiva',
                                  'CONOCIMIENTOC4':'Discapacidad visual',
                                  'CONOCIMIENTOC5':'Drenes',
                                  'CONOCIMIENTOD1':'Medicina Interna',
                                  'CONOCIMIENTOD2':'Quirúrgico',
                                  'CONOCIMIENTOD3':'Oncológico',
                                  'CONOCIMIENTOD4':'Psiquiátrico',
                                  'CONOCIMIENTOD5':'Madre recién nacido',
                                  'CONOCIMIENTOD6':'Neurológico',
                                  'CONOCIMIENTOA1':'Paciente acompañado de familiar',
                                  'CONOCIMIENTOA2':'Paciente sin compañía',
                                  'CONOCIMIENTOA3':'Paciente acompañado de empleada',
                                  'CONOCIMIENTOA4':'Toma de signos vitales',
                                  'CONOCIMIENTOA5':'Seguridad del paciente',
                                  'CONOCIMIENTOC6':'Glucometría',
                                  'CONOCIMIENTOC7':'Medicación aplicación endovenosa',
                                  'CONOCIMIENTOC8':'Nefrostomia',
                                  'CONOCIMIENTOC9':'Oxigeno',
                                  'CONOCIMIENTOC10':'Sonda Gastrostomía',
                                  'CONOCIMIENTOC11':'Sonda Naso gástrica',
                                  'CONOCIMIENTOC12':'Sonda Orogástrica',
                                  'CONOCIMIENTOC13':'Sonda Vesical',
                                  'CONOCIMIENTOC14':'Traqueostomía',
                                  'CONOCIMIENTOCC1':'Alerta/orientado',
                                  'CONOCIMIENTOCC2':'Comatoso',
                                  'CONOCIMIENTOCC3':'Confusión/desorientado',
                                  'CONOCIMIENTOCC4':'Estuporoso',
                                  'CONOCIMIENTOCC5':'Vegetativo' 
                                   }, inplace = True)
ConocimientoPref_df.head()

ConocimientoPref_df = ConocimientoPref_df.replace('SI',1)
ConocimientoPref_df = ConocimientoPref_df.replace('NO',0)


ConocimientoPref_df = ConocimientoPref_df.fillna(0)
#ConocimientoPref_df['ID'] = ConocimientoPref_df.index + 1
ConocimientoPref_df.head()


# In[8]:


##Filtra por Tipo de Compania Pref, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['ID','NIVEL_PREFERENCIA3','NIVEL_PREFERENCIA4','NIVEL_PREFERENCIA5']]
pref_aux_df_filtro_df.head()

TipoCompPref_df = pref_aux_df_filtro_df
TipoCompPref_df.rename(columns = {'NIVEL_PREFERENCIA3':'Paciente acompañado de familiar', 'NIVEL_PREFERENCIA4':'Paciente acompañado de empleada', 'NIVEL_PREFERENCIA5':'Paciente sin compañía'}, inplace = True)
TipoCompPref_df.head()

TipoCompPref_df = TipoCompPref_df.replace(1,0)
TipoCompPref_df = TipoCompPref_df.replace(2,0)
TipoCompPref_df = TipoCompPref_df.replace(3,1)
TipoCompPref_df = TipoCompPref_df.replace(4,1)
TipoCompPref_df = TipoCompPref_df.replace(5,1)

TipoCompPref_df = TipoCompPref_df.fillna(0)
#TipoCompPref_df['ID'] = TipoCompPref_df.index + 1
TipoCompPref_df.head()


# In[9]:


##Filtra por Tipo de Turno Pref, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['ID','NIVEL_PREFERENCIA1','NIVEL_PREFERENCIA2']]
pref_aux_df_filtro_df.head()


TurnoPref_df = pref_aux_df_filtro_df
TurnoPref_df.rename(columns = {'NIVEL_PREFERENCIA1':'Diurno', 'NIVEL_PREFERENCIA2':'Nocturno'}, inplace = True)
TurnoPref_df.head()

TurnoPref_df = TurnoPref_df.replace(1,0)
TurnoPref_df = TurnoPref_df.replace(2,0)
TurnoPref_df = TurnoPref_df.replace(3,1)
TurnoPref_df = TurnoPref_df.replace(4,1)
TurnoPref_df = TurnoPref_df.replace(5,1)

TurnoPref_df = TurnoPref_df.fillna(0)
#TurnoPref_df['ID'] = TurnoPref_df.index + 1
TurnoPref_df.head()


# In[10]:


##Filtra por Tipo de Turno Pref, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['ID','NIVEL_PREFERENCIA6','NIVEL_PREFERENCIA7']]
pref_aux_df_filtro_df.head()


GeneroPref_df = pref_aux_df_filtro_df
GeneroPref_df.rename(columns = {'NIVEL_PREFERENCIA6':'Masculino', 'NIVEL_PREFERENCIA7':'Femenino'}, inplace = True)
GeneroPref_df.head()

GeneroPref_df = GeneroPref_df.replace(1,0)
GeneroPref_df = GeneroPref_df.replace(2,0.4)
GeneroPref_df = GeneroPref_df.replace(3,0.6)
GeneroPref_df = GeneroPref_df.replace(4,0.8)
GeneroPref_df = GeneroPref_df.replace(5,1)

GeneroPref_df = GeneroPref_df.fillna(0)
#GeneroPref_df['ID'] = GeneroPref_df.index + 1
GeneroPref_df = GeneroPref_df[['ID','Femenino','Masculino']]
GeneroPref_df.head()


# In[11]:


#Genero del Auxiliar

pref_aux_df_filtro_df = pref_aux_df[['ID', 'GENERO']]
pref_aux_df_filtro_df.head()

Genero_Aux_df = pref_aux_df_filtro_df.pivot(index=['ID'], columns="GENERO", values="ID")
Genero_Aux_df = Genero_Aux_df.fillna(0).astype(np.int64)
Genero_Aux_df[Genero_Aux_df != 0] = 1 
#MascotaGusto_df['ID'] = MascotaGusto_df.index 
Genero_Aux_df.head()


# In[12]:


#Nacionalidad del Auxiliar

pref_aux_df_filtro_df = pref_aux_df[['ID', 'NACIONALIDAD']]
pref_aux_df_filtro_df.head()

Nacionalidad_Aux_df = pref_aux_df_filtro_df.pivot(index=['ID'], columns="NACIONALIDAD", values="ID")
Nacionalidad_Aux_df = Nacionalidad_Aux_df.fillna(0).astype(np.int64)
Nacionalidad_Aux_df[Nacionalidad_Aux_df != 0] = 1 
#Nacionalidad_Aux_df['ID'] = Nacionalidad_Aux_df.index 
Nacionalidad_Aux_df.head()


# In[13]:


#OJO NO EXISTE LA PREFERENCIA DEL PACIENTE
##Filtra por Tipo de Servicios Pref, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['ID','NIVEL_PREFERENCIA8','NIVEL_PREFERENCIA9','NIVEL_PREFERENCIA10','NIVEL_PREFERENCIA11']]
pref_aux_df_filtro_df.head()

TipoServiciosPref_df = pref_aux_df_filtro_df
TipoServiciosPref_df.rename(columns = {'NIVEL_PREFERENCIA8':'Domicilio', 'NIVEL_PREFERENCIA9':'IPS', 
                                       'NIVEL_PREFERENCIA10':'Clínicas estéticas', 'NIVEL_PREFERENCIA11':'Empresarial'}, inplace = True)
TipoServiciosPref_df.head()

TipoServiciosPref_df = TipoServiciosPref_df.replace(1,0)
TipoServiciosPref_df = TipoServiciosPref_df.replace(2,0.4)
TipoServiciosPref_df = TipoServiciosPref_df.replace(3,0.6)
TipoServiciosPref_df = TipoServiciosPref_df.replace(4,0.8)
TipoServiciosPref_df = TipoServiciosPref_df.replace(5,1)

TipoServiciosPref_df = TipoServiciosPref_df.fillna(0)
#TipoServiciosPref_df['ID'] = TipoServiciosPref_df.index + 1
TipoServiciosPref_df.head()


# In[14]:


##Filtra por Tipo de Servicios Pref, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['NIVEL_PREFERENCIA12','NIVEL_PREFERENCIA13','NIVEL_PREFERENCIA14'
                                     ,'NIVEL_PREFERENCIA15','NIVEL_PREFERENCIA16','NIVEL_PREFERENCIA17']]
pref_aux_df_filtro_df.head()

DiagnosticoPref_df = pref_aux_df_filtro_df
DiagnosticoPref_df.rename(columns = {'NIVEL_PREFERENCIA12':'Medicina Interna', 'NIVEL_PREFERENCIA13':'Quirúrgico' 
                                    ,'NIVEL_PREFERENCIA14':'Oncológico', 'NIVEL_PREFERENCIA15':'Psiquiátrico'
                                    ,'NIVEL_PREFERENCIA16':'Madre recién nacido','NIVEL_PREFERENCIA17':'Neurológico'}, inplace = True)
DiagnosticoPref_df.head()

DiagnosticoPref_df = DiagnosticoPref_df.replace(1,0)
DiagnosticoPref_df = DiagnosticoPref_df.replace(2,0.4)
DiagnosticoPref_df = DiagnosticoPref_df.replace(3,0.6)
DiagnosticoPref_df = DiagnosticoPref_df.replace(4,0.8)
DiagnosticoPref_df = DiagnosticoPref_df.replace(5,1)

DiagnosticoPref_df = DiagnosticoPref_df.fillna(0)
#DiagnosticoPref_df['ID'] = DiagnosticoPref_df.index + 1

DiagnosticoPref_df.head()


# In[15]:


##Filtra por Tipo de Servicios Pref, Pivotea las filas a columnas, Normaliza los datos : Cambia los valores nulos a 0 y los demás a 1 
pref_aux_df_filtro_df = pref_aux_df[['ID','NIVEL_PREFERENCIA18','NIVEL_PREFERENCIA19','NIVEL_PREFERENCIA20'
                                     ,'NIVEL_PREFERENCIA21','NIVEL_PREFERENCIA22']]
pref_aux_df_filtro_df.head()

CondicionSaludPref_df = pref_aux_df_filtro_df
CondicionSaludPref_df.rename(columns = {'NIVEL_PREFERENCIA18':'Alerta/orientado', 'NIVEL_PREFERENCIA19':'Comatoso' 
                                    ,'NIVEL_PREFERENCIA20':'Confusión/desorientado', 'NIVEL_PREFERENCIA21':'Estuporoso'
                                    ,'NIVEL_PREFERENCIA22':'Vegetativo'}, inplace = True)
CondicionSaludPref_df.head()

CondicionSaludPref_df = CondicionSaludPref_df.replace(1,0)
CondicionSaludPref_df = CondicionSaludPref_df.replace(2,0.4)
CondicionSaludPref_df = CondicionSaludPref_df.replace(3,0.6)
CondicionSaludPref_df = CondicionSaludPref_df.replace(4,0.8)
CondicionSaludPref_df = CondicionSaludPref_df.replace(5,1)

CondicionSaludPref_df = CondicionSaludPref_df.fillna(0)
#CondicionSaludPref_df['ID'] = CondicionSaludPref_df.index + 1
CondicionSaludPref_df.head()


# In[16]:



pref_aux_df_filtro_df = pref_aux_df[['ID', 'GUSTOS_PRESENCIA_MASCOTAS']]
pref_aux_df_filtro_df.head()

MascotaGusto_df = pref_aux_df_filtro_df.pivot(index=['ID'], columns="GUSTOS_PRESENCIA_MASCOTAS", values="ID")
MascotaGusto_df = MascotaGusto_df.fillna(0).astype(np.int64)
MascotaGusto_df[MascotaGusto_df != 0] = 1 
#MascotaGusto_df['ID'] = MascotaGusto_df.index 
MascotaGusto_df.head()


# In[17]:


#PRIORIDAD_PREFERENCIA_TURNO
pref_aux_df_filtro_df = pref_aux_df[['ID','PRIORIDAD_PREFERENCIA_TURNO']]
pref_aux_df_filtro_df.head()

TurnoPrior_df = pref_aux_df_filtro_df

TurnoPrior_df.head()

TurnoPrior_df = TurnoPrior_df.replace(1,0)
TurnoPrior_df = TurnoPrior_df.replace(2,0.4)
TurnoPrior_df = TurnoPrior_df.replace(3,0.6)
TurnoPrior_df = TurnoPrior_df.replace(4,0.8)
TurnoPrior_df = TurnoPrior_df.replace(5,1)

TurnoPrior_df = TurnoPrior_df.fillna(0)
#TurnoPrior_df['ID'] = TurnoPrior_df.index + 1
TurnoPrior_df.head()




# In[18]:


#PRIORIDAD_PREFERENCIA_ACOMPAÑA
pref_aux_df_filtro_df = pref_aux_df[['ID','PRIORIDAD_PREFERENCIA_ACOMPAÑA']]
pref_aux_df_filtro_df.head()

AcompanaPrior_df = pref_aux_df_filtro_df

AcompanaPrior_df.head()

AcompanaPrior_df = AcompanaPrior_df.replace(1,0)
AcompanaPrior_df = AcompanaPrior_df.replace(2,0.4)
AcompanaPrior_df = AcompanaPrior_df.replace(3,0.6)
AcompanaPrior_df = AcompanaPrior_df.replace(4,0.8)
AcompanaPrior_df = AcompanaPrior_df.replace(5,1)

AcompanaPrior_df = AcompanaPrior_df.fillna(0)
#AcompanaPrior_df['ID'] = AcompanaPrior_df.index + 1
AcompanaPrior_df.head()


# In[19]:


#PRIORIDAD_PREFERENCIA_EDAD
pref_aux_df_filtro_df = pref_aux_df[['ID','PRIORIDAD_PREFERENCIA_EDAD']]
pref_aux_df_filtro_df.head()

EdadPrior_df = pref_aux_df_filtro_df

EdadPrior_df.head()

EdadPrior_df = EdadPrior_df.replace(1,0)
EdadPrior_df = EdadPrior_df.replace(2,0.4)
EdadPrior_df = EdadPrior_df.replace(3,0.6)
EdadPrior_df = EdadPrior_df.replace(4,0.8)
EdadPrior_df = EdadPrior_df.replace(5,1)

EdadPrior_df = EdadPrior_df.fillna(0)
#EdadPrior_df['ID'] = EdadPrior_df.index + 1
EdadPrior_df.head()


# In[20]:


#PRIORIDAD_PREFERENCIA_SERVICIO
pref_aux_df_filtro_df = pref_aux_df[['ID','PRIORIDAD_PREFERENCIA_SERVICIO']]
pref_aux_df_filtro_df.head()

ServicioPrior_df = pref_aux_df_filtro_df

ServicioPrior_df.head()

ServicioPrior_df = ServicioPrior_df.replace(1,0)
ServicioPrior_df = ServicioPrior_df.replace(2,0.4)
ServicioPrior_df = ServicioPrior_df.replace(3,0.6)
ServicioPrior_df = ServicioPrior_df.replace(4,0.8)
ServicioPrior_df = ServicioPrior_df.replace(5,1)

ServicioPrior_df = ServicioPrior_df.fillna(0)
#ServicioPrior_df['ID'] = ServicioPrior_df.index + 1
ServicioPrior_df.head()


# In[21]:


#Restricción levantar Objetos Pesados Auxiliar
pref_aux_df_filtro_df = pref_aux_df[['ID', 'RESTRICCION_OBJETOS']]
pref_aux_df_filtro_df.head()

RestriccionObj_df = pref_aux_df_filtro_df.pivot(index=['ID'], columns="RESTRICCION_OBJETOS", values="ID")
RestriccionObj_df = RestriccionObj_df.fillna(0).astype(np.int64)
RestriccionObj_df[RestriccionObj_df != 0] = 1 
#RestriccionObj_df['ID'] = RestriccionObj_df.index 
RestriccionObj_df.head()


# In[22]:


# Creating a lambda expression for datetime parsing
dateparse = lambda x: datetime.strptime(x, "%d/%m/%Y")


# In[23]:


# Analyzing unique values for column FECHA HECHO
pref_aux_df['FECHA NACIMIENTO']=pref_aux_df['FECHA NACIMIENTO'].apply(dateparse)


# In[24]:


#edadparse, calcula la edad del auxiliar
today = date.today()
edadparse = lambda x: today.year - x.year - ((today.month, 
                                          today.day) <(x.month, x.day))
#rangoEdadParse, calcula el rango de edad para hacer match con las preferencias del paciente
rangoEdadParse = lambda x : 'Rango de Edad 20-35' if x >= 20 and x <= 35 else ('Rango de Edad 36-50' if  x >= 36 and x <= 50 else 'Rango de Edad mayor de 50')

pref_aux_df['EDAD']=pref_aux_df['FECHA NACIMIENTO'].apply(edadparse)

pref_aux_df['RANGO_EDAD']=pref_aux_df['EDAD'].apply(rangoEdadParse)


# In[25]:


#Edad Preferencia :Edad Auxiliar
pref_aux_df_filtro_df = pref_aux_df[['ID', 'RANGO_EDAD']]
pref_aux_df_filtro_df.head()

RangoEdad_df = pref_aux_df_filtro_df.pivot(index=['ID'], columns="RANGO_EDAD", values="ID")
RangoEdad_df = RangoEdad_df.fillna(0).astype(np.int64)
RangoEdad_df[RangoEdad_df != 0] = 1 
#RestriccionObj_df['ID'] = RestriccionObj_df.index 
RangoEdad_df.head()


# In[ ]:





# In[ ]:





# In[ ]:





# In[26]:


# Loading los datos de los pacientes CSV file as dataframe, showing first rows
dat_pac_df = pd.read_csv('data/Pacientes.csv',sep=";",header= 0, encoding='latin-1')


# In[27]:


# Showing first rows
dat_pac_df.head()


# In[28]:


dat_pac_df.dtypes


# In[29]:


#Condición de Salud : Experiencia Auxiliar
pac_df_filtro_df = dat_pac_df[['ID', 'CONDICION SALUD']]
pac_df_filtro_df.head()

CondicionSaludPac_df = pac_df_filtro_df.pivot(index=['ID'], columns="CONDICION SALUD", values="ID")
CondicionSaludPac_df = CondicionSaludPac_df.fillna(0).astype(np.int64)
CondicionSaludPac_df[CondicionSaludPac_df != 0] = 1 
#CondicionSaludPac_df['ID'] = CondicionSaludPac_df.index 
CondicionSaludPac_df.head()


# In[30]:


#Diagnostico : Experiencia Auxiliar
pac_df_filtro_df = dat_pac_df[['ID', 'GRUPO DIAGNOSTICO']]
pac_df_filtro_df.head()

DiagnosticoPac_df = pac_df_filtro_df.pivot(index=['ID'], columns="GRUPO DIAGNOSTICO", values="ID")
DiagnosticoPac_df = DiagnosticoPac_df.fillna(0).astype(np.int64)
DiagnosticoPac_df[DiagnosticoPac_df != 0] = 1 

#DiagnosticoPac_df['ID'] = DiagnosticoPac_df.index 
DiagnosticoPac_df.head()


# In[31]:


#Nivel de Conciencia : Experiencia Auxiliar
pac_df_filtro_df = dat_pac_df[['ID', 'NIVEL CONCIENCIA']]
pac_df_filtro_df.head()

NivelConcienciaPac_df = pac_df_filtro_df.pivot(index=['ID'], columns="NIVEL CONCIENCIA", values="ID")
NivelConcienciaPac_df = NivelConcienciaPac_df.fillna(0).astype(np.int64)
NivelConcienciaPac_df[NivelConcienciaPac_df != 0] = 1 
#NivelConcienciaPac_df['ID'] = NivelConcienciaPac_df.index
NivelConcienciaPac_df = NivelConcienciaPac_df[["Alerta/orientado","Comatoso","Confusión/desorientado","Estuporoso","Vegetativo","No aplica"]]
NivelConcienciaPac_df.head()


# In[32]:


#Compañia Paciente : Experiencia Auxiliar
pac_df_filtro_df = dat_pac_df[['ID', 'PERSONA_ACOMPAÑA']]
pac_df_filtro_df.head()

CompaniaPac_df = pac_df_filtro_df.pivot(index=['ID'], columns="PERSONA_ACOMPAÑA", values="ID")
CompaniaPac_df = CompaniaPac_df.fillna(0).astype(np.int64)
CompaniaPac_df[CompaniaPac_df != 0] = 1 
#CompaniaPac_df['ID'] = CompaniaPac_df.index 
CompaniaPac_df = CompaniaPac_df[["Paciente acompañado de empleada",
                                                "Paciente acompañado de familiar",
                                                "Paciente sin compañía"]]
CompaniaPac_df.head()


# In[33]:


#Nivel de Dependencia : Restricciones laborales
pac_df_filtro_df = dat_pac_df[['ID', 'NIVEL AUTONOMIA']]
pac_df_filtro_df.head()

pac_df_filtro_df = pac_df_filtro_df.replace('Dependiente Total','NO')
pac_df_filtro_df = pac_df_filtro_df.replace('Dependiente Severo/a','NO')
pac_df_filtro_df = pac_df_filtro_df.replace('Independiente','SI')
pac_df_filtro_df = pac_df_filtro_df.replace('Dependiente Moderado','NO')
pac_df_filtro_df = pac_df_filtro_df.replace('No aplica','SI')
pac_df_filtro_df = pac_df_filtro_df.replace('Dependencia Escasa','NO')

DependenciaPac_df = pac_df_filtro_df.pivot(index=['ID'], columns="NIVEL AUTONOMIA", values="ID")

DependenciaPac_df = DependenciaPac_df.fillna(0).astype(np.int64)
DependenciaPac_df[DependenciaPac_df != 0] = 1 
#DependenciaPac_df['ID'] = DependenciaPac_df.index 
DependenciaPac_df.head()


# In[34]:


#Temperamento : Personalidad
pac_df_filtro_df = dat_pac_df[['ID', 'TEMPERAMENTO']]
pac_df_filtro_df.head()

TemperamentoPac_df = pac_df_filtro_df.pivot(index=['ID'], columns="TEMPERAMENTO", values="ID")
TemperamentoPac_df = TemperamentoPac_df.fillna(0).astype(np.int64)
TemperamentoPac_df[TemperamentoPac_df != 0] = 1 
#TemperamentoPac_df['ID'] = TemperamentoPac_df.index 
TemperamentoPac_df.head()


# In[35]:


#Tipo de Servicio : FALTA
#Lugar de Residencia : FALTA


# In[36]:


#Genero de Servicio Preferencia : Genero Auxiliar
pac_df_filtro_df = dat_pac_df[['ID', 'PREFERENCIA_GENERO']]
pac_df_filtro_df.head()

GeneroPrefPac_df = pac_df_filtro_df.pivot(index=['ID'], columns="PREFERENCIA_GENERO", values="ID")
GeneroPrefPac_df = GeneroPrefPac_df.fillna(0).astype(np.int64)
GeneroPrefPac_df[GeneroPrefPac_df != 0] = 1 
#GeneroPrefPac_df['ID'] = GeneroPrefPac_df.index 
GeneroPrefPac_df.head()


# In[37]:


#Nacionalidad Preferencia : Nacionalidad Auxiliar
pac_df_filtro_df = dat_pac_df[['ID', 'PREFERENCIA_NACIONALIDAD']]
pac_df_filtro_df.head()

NacionalidadPrefPac_df = pac_df_filtro_df.pivot(index=['ID'], columns="PREFERENCIA_NACIONALIDAD", values="ID")
NacionalidadPrefPac_df = NacionalidadPrefPac_df.fillna(0).astype(np.int64)
NacionalidadPrefPac_df[NacionalidadPrefPac_df != 0] = 1 
#NacionalidadPrefPac_df['ID'] = NacionalidadPrefPac_df.index 
NacionalidadPrefPac_df.head()


# In[38]:


#Mascotas Preferencia : Nacionalidad Auxiliar
pac_df_filtro_df = dat_pac_df[['ID', 'PREFERENCIA_MASCOTAS']]
pac_df_filtro_df.head()

MascotasPrefPac_df = pac_df_filtro_df.pivot(index=['ID'], columns="PREFERENCIA_MASCOTAS", values="ID")
MascotasPrefPac_df = MascotasPrefPac_df.fillna(0).astype(np.int64)
MascotasPrefPac_df[MascotasPrefPac_df != 0] = 1 
#MascotasPrefPac_df['ID'] = MascotasPrefPac_df.index 
MascotasPrefPac_df.head()


# In[39]:


#Mascotas Preferencia : Nacionalidad Auxiliar
pac_df_filtro_df = dat_pac_df[['ID', 'PREFERENCIA_EDAD']]
pac_df_filtro_df.head()

EdadPrefPac_df = pac_df_filtro_df.pivot(index=['ID'], columns="PREFERENCIA_EDAD", values="ID")
EdadPrefPac_df = EdadPrefPac_df.fillna(0).astype(np.int64)
EdadPrefPac_df[EdadPrefPac_df != 0] = 1 
#MascotasPrefPac_df['ID'] = MascotasPrefPac_df.index 
EdadPrefPac_df.head()


# In[ ]:





# In[ ]:





# In[ ]:





# In[ ]:





# In[ ]:





# In[ ]:





# In[ ]:





# In[ ]:





# In[40]:


#Implementación de la similaridad del coseno 
#Se elimina la columna del id del arreglo, esto ayuda a que la distancia sea más aproximada.
def SimilaridadCoseno(pacientePref, auxiliarPref):
    #inicializamos los sumatorios en 0
    sumxx, sumxy, sumyy = 0, 0, 0

    #cálculamos los sumatorios del númerador y el denominador
    for i in range(1, len(pacientePref), 1):
        x = pacientePref[i]
        y = auxiliarPref[i]
        #print(x)
        #print(y)
        sumxx += x*x
        sumyy += y*y
        sumxy += x*y
    
    #Simplificamos la ecuación, ahorrandonos hacer dos raices cuadradas, para que sea más rápido
    if (sumxx == 0 or sumyy == 0):
        return 0.0
    else:
        return sumxy/np.sqrt((sumxx*sumyy))


# In[41]:


#Se crea un dataframe del auxiliar unicamente con los datos que contiene los diagnosticos del paciente
#Se quita el ID del dataframe para coinicidir el número de las columnas con el dataframe de los pacientes
ExperienciaDiagnosticoPref_df = ExperienciaPref_df[['Madre recién nacido','Medicina Interna','Neurológico','Oncológico'
                                            ,'Psiquiátrico','Quirúrgico']]

#Se crea un dataframe del auxiliar unicamente con los datos que contiene las condiciones del paciente.
#Se quita el ID del dataframe para coinicidir el número de las columnas con el dataframe de los pacientes
ExperienciaCondicionesPref_df=0
ExperienciaCondicionesPref_df = ExperienciaPref_df[['Alerta/orientado','Comatoso','Confusión/desorientado',
                                                    'Estuporoso','Vegetativo']]

#Se crea un dataframe del auxiliar uniamente con los datos que contiene los niveles de conciencia
ExperienciaNivelConcienciaPref_df = ExperienciaCondicionesPref_df
ExperienciaNivelConcienciaPref_df['No aplica'] = 0
ExperienciaNivelConcienciaPref_df.head()


ExperienciaCompaniaPref_df = ExperienciaPref_df[["Paciente acompañado de empleada",
                                                "Paciente acompañado de familiar",
                                                "Paciente sin compañía"]]


Conocimiento_CondicionPacPref_df = ConocimientoPref_df[["Colostomía",
"Discapacidad visual",
"Drenes",
"Glucometría",
"Medicación aplicación endovenosa",
"Nefrostomia",
"Oxigeno",
"Sonda Gastrostomía",
"Sonda Naso gástrica",
"Sonda Orogástrica",
"Sonda Vesical",
"Traqueostomía"]]

Conocimiento_DiagnosticoPacPref_df = ConocimientoPref_df[["Medicina Interna",
"Quirúrgico",
"Oncológico",
"Psiquiátrico",
"Madre recién nacido",
"Neurológico"]]


# In[42]:


#Encontrar auxiliares similares con las preferencias de los pacientes.
df1=DiagnosticoPac_df.reset_index()
df2=ExperienciaPref_df.reset_index()
df1.loc[0].values
df2.loc[0].values
SimilaridadCoseno(df1.loc[0].values, df2.loc[2].values)
df1.loc[0].values


# In[43]:


#Datos del Paciente 1
df1.loc[0].values


# In[44]:


#Experiencia del Auxiliar 1
df2.loc[0].values


# In[45]:


#Prueba con los valores
SimilaridadCoseno(df1.loc[0].values, df2.loc[1].values)


# In[46]:


#Pruebas con los valores
SimilaridadCoseno(df1.loc[0].values, df2.loc[2].values)


# In[47]:


#CondicionSaludPref_df
#ExperienciaPref_df
#Diagnóstico del paciente en el que el auxiliar tenga experiencia.
df1=CondicionSaludPref_df.reset_index()
#df2=ExperienciaPref_df.reset_index()
df2=ExperienciaCondicionesPref_df.reset_index()
Recom_CondPac_ExpAux_df = pd.DataFrame()
df = pd.DataFrame(columns=['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14'
                          ,'15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28'
                          , '29', '30', '31', '32'],
                  index=range(32))

#df_New = pd.DataFrame()
df_New = pd.DataFrame(columns=[],
                  index=range(1))
#print(len(TipoCompPac_df))
#print(len(TipoCompPref_df))

for idPaciente in range(len(df1)):
    #print("Paciente", idPaciente)
    ls_dataSimilar = []
    for idAuxiliar in range(len(df2)):
        ls_dataSimilar.append(SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        #df_New[idAuxiliar] = pd.DataFrame(ls_dataSimilar)
        df_New[idAuxiliar] = (SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        
    
    Recom_CondPac_ExpAux_df = Recom_CondPac_ExpAux_df.append(df_New, ignore_index=True)


Recom_CondPac_ExpAux_df.head(20)


# In[48]:


#DiagnosticoPac_df
#ExperienciaPref_df
#Diagnóstico del paciente en el que el auxiliar tenga experiencia.
df1=DiagnosticoPac_df.reset_index()
#df2=ExperienciaPref_df.reset_index()
df2=ExperienciaDiagnosticoPref_df.reset_index()
Recom_DiagPac_ExpAux_df = pd.DataFrame()
df = pd.DataFrame(columns=['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14'
                          ,'15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28'
                          , '29', '30', '31', '32'],
                  index=range(32))

#df_New = pd.DataFrame()
df_New = pd.DataFrame(columns=[],
                  index=range(1))
#print(len(TipoCompPac_df))
#print(len(TipoCompPref_df))

for idPaciente in range(len(df1)):
    #print("Paciente", idPaciente)
    ls_dataSimilar = []
    for idAuxiliar in range(len(df2)):
        ls_dataSimilar.append(SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        #df_New[idAuxiliar] = pd.DataFrame(ls_dataSimilar)
        df_New[idAuxiliar] = (SimilaridadCoseno(df1.loc[idPaciente].values, df2.loc[idAuxiliar].values))
        
    
    Recom_DiagPac_ExpAux_df = Recom_DiagPac_ExpAux_df.append(df_New, ignore_index=True)


Recom_DiagPac_ExpAux_df.head(20)


# In[49]:


#NivelConcienciaPac_df
#ExperienciaPref_df
#Nivel de conciencia del paciente en el que el auxiliar tiene experiencia
df1=NivelConcienciaPac_df.reset_index()
#df2=ExperienciaPref_df.reset_index()
df2=ExperienciaNivelConcienciaPref_df.reset_index()
Recom_NConcienciaPac_Exp_Aux_df = pd.DataFrame()
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
        
    
    Recom_NConcienciaPac_Exp_Aux_df = Recom_NConcienciaPac_Exp_Aux_df.append(df_New, ignore_index=True)


Recom_NConcienciaPac_Exp_Aux_df.head(20)


# In[50]:


#CompaniaPac_df
#ExperienciaPref_df
#Tipo de compañía en el que el auxiliar tiene experiencia
df1=CompaniaPac_df.reset_index()
#df2=ExperienciaPref_df.reset_index()
df2=ExperienciaCompaniaPref_df.reset_index()
Recom_CompaniaPac_ExpAux_df = pd.DataFrame()
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
        
    
    Recom_CompaniaPac_ExpAux_df = Recom_CompaniaPac_ExpAux_df.append(df_New, ignore_index=True)


Recom_CompaniaPac_ExpAux_df.head(20)


# In[51]:


#DependenciaPac_df 
#Restricciones objetos
#Nivel de dependencia del paciente en el que el que el auxiliar no tenga restricciones.
df1=DependenciaPac_df.reset_index()
df2=RestriccionObj_df.reset_index()
Recom_DependenciaPac_RestAux_df = pd.DataFrame()
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
        
    
    Recom_DependenciaPac_RestAux_df = Recom_DependenciaPac_RestAux_df.append(df_New, ignore_index=True)


Recom_DependenciaPac_RestAux_df.head(20)


# In[52]:


#CondicionSaludPac_df
#ConocimientoPref_df
#Condición de salud del Paciente con el conocimiento del auxiliar
df1=CondicionSaludPac_df.reset_index()
#df2=ConocimientoPref_df.reset_index()
df2=Conocimiento_CondicionPacPref_df.reset_index()
Recom_CondPac_ConAux_df = pd.DataFrame()
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
        
    
    Recom_CondPac_ConAux_df = Recom_CondPac_ConAux_df.append(df_New, ignore_index=True)


Recom_CondPac_ConAux_df.head(20)


# In[53]:


#DiagnosticoPref_df
#ConocimientoPref_df
#Diagnóstico del Paciente en el que el auxiliar tiene conocimento
df1=DiagnosticoPref_df.reset_index()
#df2=ConocimientoPref_df.reset_index()
df2=Conocimiento_DiagnosticoPacPref_df.reset_index()
Recom_DiagPac_ConAux_df = pd.DataFrame()
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
        
    
    Recom_DiagPac_ConAux_df = Recom_DiagPac_ConAux_df.append(df_New, ignore_index=True)


Recom_DiagPac_ConAux_df.head(20)


# In[54]:


#EdadPrefPac_df
#RangoEdad_df
#Edad de preferencia del paciente
df1=EdadPrefPac_df.reset_index()
df2=RangoEdad_df.reset_index()
Recom_EdadPac_EdadAux_df = pd.DataFrame()
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
        
    
    Recom_EdadPac_EdadAux_df = Recom_EdadPac_EdadAux_df.append(df_New, ignore_index=True)


Recom_EdadPac_EdadAux_df.head(20)


# In[55]:


#GeneroPrefPac_df
#GeneroPref_df
#Genero de preferencia del paciente
df1=GeneroPrefPac_df.reset_index()
df2=Genero_Aux_df.reset_index()
Recom_GeneroPac_GeneroAux_df = pd.DataFrame()
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
        
    
    Recom_GeneroPac_GeneroAux_df = Recom_GeneroPac_GeneroAux_df.append(df_New, ignore_index=True)


Recom_GeneroPac_GeneroAux_df.head(20)


# In[56]:


#NacionalidadPrefPac_df
#Nacionalidad_Aux_df
#Genero de preferencia del paciente
df1=NacionalidadPrefPac_df.reset_index()
df2=Nacionalidad_Aux_df.reset_index()
Recom_NacionalidadPac_NacionalidadAux_df = pd.DataFrame()
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
        
    
    Recom_NacionalidadPac_NacionalidadAux_df = Recom_NacionalidadPac_NacionalidadAux_df.append(df_New, ignore_index=True)


Recom_NacionalidadPac_NacionalidadAux_df.head(20)


# In[57]:


##Seleccionar todos los dataset de recomendaciones para promediar los valores de cada campo y luego de eso si se puede
##continuar con el ordenamiento de los valores para ordenar los auxiliares con mejor match.
##Acá se deben unir todas las celdas y dividir por la cantidad de datasets.
#Estos no van porque es paciente con auxiliar
#Recom_CondPac_ExpAux_df
#Recom_DiagPac_ConAux_df

Recom_Pac_Aux = (
Recom_DiagPac_ExpAux_df +
Recom_NConcienciaPac_Exp_Aux_df +
Recom_CompaniaPac_ExpAux_df +
Recom_DependenciaPac_RestAux_df +
#Recom_CondPac_ConAux_df +
#Recom_DiagPac_ConAux_df +
Recom_EdadPac_EdadAux_df +
Recom_GeneroPac_GeneroAux_df+
Recom_NacionalidadPac_NacionalidadAux_df)/7

Recom_Pac_Aux.head()


# In[58]:


#Para todos los pacientes
#Se ordena los auxiliares con mayor coincidencia en el perfil del auxiliar con el del paciente
#Se pasa a una lista ordenada
resultado_Pac_df = pd.DataFrame()
recomendacion_Pac_df = pd.DataFrame()
resultado_df = pd.DataFrame()
resultado_aux_Pac_df = pd.DataFrame()

df3 = Recom_Pac_Aux

for idPaciente in range(len(df3)):
    array_Pac_df = df3.loc[idPaciente].values
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
    
    
    
    
resultado = resultado_Pac_df.reset_index()
#resultado.columns.values[0] = "Paciente"
resultado['index'] = resultado.index 
resultado.rename(columns = {'index':'Paciente'}, inplace = True)
resultado.head(10)


# In[59]:


resultado.to_csv('data/Turnos.csv',sep=";",header= 0)


# In[ ]:





# In[ ]:





# In[ ]:




