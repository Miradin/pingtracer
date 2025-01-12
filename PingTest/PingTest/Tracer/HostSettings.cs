﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PingTracer.Tracer
{
	/// <summary>
	/// Defines host(s) to ping, along with various related options.
	/// </summary>
	public class HostSettings
	{
		public string host;
		public string displayName = "";
		public int rate = 1;
		public bool pingsPerSecond = true;
		public bool doTraceRoute = true;
		public bool reverseDnsLookup = true;
		public bool drawServerNames = true;
		public bool drawLastPing = true;
		public bool drawAverage = true;
		public bool drawJitter = true;
		public bool drawMinMax = false;
		public bool drawPacketLoss = true;
		public int badThreshold = 100;
		public int worseThreshold = 200;
		public bool preferIpv4 = true;

		public override bool Equals(object other)
		{
			if (other is HostSettings)
			{
				HostSettings o = (HostSettings)other;
				return host == o.host
					&& rate == o.rate
					&& pingsPerSecond == o.pingsPerSecond
					&& doTraceRoute == o.doTraceRoute
					&& reverseDnsLookup == o.reverseDnsLookup
					&& drawServerNames == o.drawServerNames
					&& drawMinMax == o.drawMinMax
					&& drawPacketLoss == o.drawPacketLoss
					&& badThreshold == o.badThreshold
					&& worseThreshold == o.worseThreshold
					&& preferIpv4 == o.preferIpv4;
			}
			return false;
		}
		public override int GetHashCode()
		{
			return host.GetHashCode() ^ rate.GetHashCode() ^ badThreshold.GetHashCode() ^ worseThreshold.GetHashCode();
		}
	}
}
