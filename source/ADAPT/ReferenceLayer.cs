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
    public abstract class ReferenceLayer
    {
        protected ReferenceLayer()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
        }

        public CompoundIdentifier Id { get; private set; }

        public string Description { get; set; }

        //Todo: Update UML and wiki to Enumerated Value instead of Enumerated representation
        public EnumeratedValue LayerType { get; set; }

        public TimeScope TimeScope { get; set; }

        public Polygon BoundingPolygon { get; set; }

        public List<ContextItem> ContextItems { get; set; }
    }
}