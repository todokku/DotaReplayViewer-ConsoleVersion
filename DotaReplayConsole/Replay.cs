﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaReplayConsole
{
    class Replay
    {
        public int Match_id { get; set; }
        public int Cluster { get; set; }
        public int Replay_salt { get; set; }

        public Replay(int id, int cluster, int replaySalt)
        {
            this.Match_id = id;
            this.Cluster = cluster;
            this.Replay_salt = replaySalt;
        }
    }
}
