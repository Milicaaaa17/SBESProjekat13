﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface ICommunication
    {
        [OperationContract(IsOneWay = true)]
        void TestCommunication();

        [OperationContract]
        void PingServer(DateTime vreme);

    }
}
