/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Tarak Reddy, Tim Shearouse - initial API and implementation
  *******************************************************************************/  

using System.Collections.Generic;

namespace AgGateway.ADAPT.ApplicationDataModel
{
    public class ReferenceData
    {
        public List<Brand> Brands { get; set; }
        public List<Connector> Connectors { get; set; }
        public List<Crop> Crops { get; set; }
        public List<CropSeason> CropSeaons { get; set; }
        public List<CropZone> CropZones { get; set; }
        public List<Farm> Farms { get; set; }
        public List<Field> Fields { get; set; }
        public List<FieldBoundary> FieldBoundaries { get; set; }
        public List<Grower> Growers { get; set; }
        public List<Guidance> Guidances { get; set; } 
        public List<Implement> Implements { get; set; } 
        public List<ImplementModel> ImplementModels { get; set; }
        public List<ImplementType> ImplementTypes { get; set; } 
        public string Name { get; set; }
        public List<Person> Persons { get; set; } 
        public List<PersonRole> PersonRoles { get; set; }
        public List<Product> Products { get; set; } 
        public List<TimeScope> TimeScopes { get; set; }
        public List<Machine> Machines { get; set; }
        public List<MachineModel> MachineModels { get; set; }
        public List<MachineSeries> MachineSeries { get; set; }
        public List<MachineType> MachineTypes { get; set; } 
        public List<Note> Notes { get; set; }
        public List<OperationData> OperationDatas { get; set; } 
        public List<WorkItem> WorkItems { get; set; } 
        public List<WorkItemOperation> WorkItemOperations { get; set; } 
    }
}