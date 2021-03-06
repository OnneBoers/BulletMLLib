using NUnit.Framework;
using System;
using BulletMLLib;

namespace BulletMLTests
{
	[TestFixture()]
	public class SpeedNodeTest
	{
		[Test()]
		public void CreatedSpeedNode()
		{
			string filename = @"Content\FireSpeed.xml";
			BulletPattern pattern = new BulletPattern();
			pattern.ParseXML(filename);

			Assert.IsNotNull(pattern.RootNode);
		}

		[Test()]
		public void CreatedSpeedNode1()
		{
			string filename = @"Content\FireSpeed.xml";
			BulletPattern pattern = new BulletPattern();
			pattern.ParseXML(filename);

			ActionNode testActionNode = pattern.RootNode.GetChild(ENodeName.action) as ActionNode;
			Assert.IsNotNull(testActionNode.GetChild(ENodeName.fire));
			FireNode testFireNode = testActionNode.GetChild(ENodeName.fire) as FireNode;
			Assert.IsNotNull(testFireNode);
		}

		[Test()]
		public void CreatedSpeedNode2()
		{
			string filename = @"Content\FireSpeed.xml";
			BulletPattern pattern = new BulletPattern();
			pattern.ParseXML(filename);

			ActionNode testActionNode = pattern.RootNode.GetChild(ENodeName.action) as ActionNode;
			FireNode testFireNode = testActionNode.GetChild(ENodeName.fire) as FireNode;
			Assert.IsNotNull(testFireNode.GetChild(ENodeName.speed));
		}
		
		[Test()]
		public void CreatedSpeedNode3()
		{
			string filename = @"Content\FireSpeed.xml";
			BulletPattern pattern = new BulletPattern();
			pattern.ParseXML(filename);

			ActionNode testActionNode = pattern.RootNode.GetChild(ENodeName.action) as ActionNode;
			FireNode testFireNode = testActionNode.GetChild(ENodeName.fire) as FireNode;
			Assert.IsNotNull(testFireNode.GetChild(ENodeName.speed) as SpeedNode);
		}

		[Test()]
		public void SpeedNodeDefaultValue()
		{
			string filename = @"Content\FireSpeed.xml";
			BulletPattern pattern = new BulletPattern();
			pattern.ParseXML(filename);

			ActionNode testActionNode = pattern.RootNode.GetChild(ENodeName.action) as ActionNode;
			FireNode testFireNode = testActionNode.GetChild(ENodeName.fire) as FireNode;
			SpeedNode testSpeedNode = testFireNode.GetChild(ENodeName.speed) as SpeedNode;

			Assert.AreEqual(ENodeType.absolute, testSpeedNode.NodeType);
		}

		[Test()]
		public void SpeedNodeAbsolute()
		{
			string filename = @"Content\FireSpeedAbsolute.xml";
			BulletPattern pattern = new BulletPattern();
			pattern.ParseXML(filename);

			ActionNode testActionNode = pattern.RootNode.GetChild(ENodeName.action) as ActionNode;
			FireNode testFireNode = testActionNode.GetChild(ENodeName.fire) as FireNode;
			SpeedNode testSpeedNode = testFireNode.GetChild(ENodeName.speed) as SpeedNode;

			Assert.AreEqual(ENodeType.absolute, testSpeedNode.NodeType);
		}

		[Test()]
		public void SpeedNodeSequence()
		{
			string filename = @"Content\FireSpeedSequence.xml";
			BulletPattern pattern = new BulletPattern();
			pattern.ParseXML(filename);

			ActionNode testActionNode = pattern.RootNode.GetChild(ENodeName.action) as ActionNode;
			FireNode testFireNode = testActionNode.GetChild(ENodeName.fire) as FireNode;
			SpeedNode testSpeedNode = testFireNode.GetChild(ENodeName.speed) as SpeedNode;

			Assert.AreEqual(ENodeType.sequence, testSpeedNode.NodeType);
		}

		[Test()]
		public void SpeedNodeRelative()
		{
			string filename = @"Content\FireSpeedRelative.xml";
			BulletPattern pattern = new BulletPattern();
			pattern.ParseXML(filename);

			ActionNode testActionNode = pattern.RootNode.GetChild(ENodeName.action) as ActionNode;
			FireNode testFireNode = testActionNode.GetChild(ENodeName.fire) as FireNode;
			SpeedNode testSpeedNode = testFireNode.GetChild(ENodeName.speed) as SpeedNode;

			Assert.AreEqual(ENodeType.relative, testSpeedNode.NodeType);
		}
	}
}

