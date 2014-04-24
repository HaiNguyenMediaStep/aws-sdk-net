/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Delete Replication Group Request Marshaller
    /// </summary>       
    public class DeleteReplicationGroupRequestMarshaller : IMarshaller<IRequest, DeleteReplicationGroupRequest>
    {
        public IRequest Marshall(DeleteReplicationGroupRequest deleteReplicationGroupRequest)
        {
            IRequest request = new DefaultRequest(deleteReplicationGroupRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "DeleteReplicationGroup");
            request.Parameters.Add("Version", "2014-03-24");
            if (deleteReplicationGroupRequest != null && deleteReplicationGroupRequest.IsSetReplicationGroupId())
            {
                request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(deleteReplicationGroupRequest.ReplicationGroupId));
            }
            if (deleteReplicationGroupRequest != null && deleteReplicationGroupRequest.IsSetRetainPrimaryCluster())
            {
                request.Parameters.Add("RetainPrimaryCluster", StringUtils.FromBool(deleteReplicationGroupRequest.RetainPrimaryCluster));
            }
            if (deleteReplicationGroupRequest != null && deleteReplicationGroupRequest.IsSetFinalSnapshotIdentifier())
            {
                request.Parameters.Add("FinalSnapshotIdentifier", StringUtils.FromString(deleteReplicationGroupRequest.FinalSnapshotIdentifier));
            }

            return request;
        }
    }
}
