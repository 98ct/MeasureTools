using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml;

namespace Canvas.DrawTools
{
	class Photo : INodePoint
	{
		public enum ePoint
		{
			P1,
			P2,
		}
		static bool m_angleLocked = false;
		Line m_owner;
		Line m_clone;
		UnitPoint m_originalPoint;
		UnitPoint m_endPoint;
		ePoint m_pointId;
		public Photo()
		{
		 
		}
		#region INodePoint Members
		public IDrawObject GetClone()
		{
			return m_clone;
		}
		public IDrawObject GetOriginal()
		{
			return m_owner;
		}
		public void SetPosition(UnitPoint pos)
		{
			if (Control.ModifierKeys == Keys.Control)
				pos = HitUtil.OrthoPointD(OtherPoint(m_pointId), pos, 45);
			if (m_angleLocked || Control.ModifierKeys == (Keys)(Keys.Control | Keys.Shift))
				pos = HitUtil.NearestPointOnLine(m_owner.P1, m_owner.P2, pos, true);
			SetPoint(m_pointId, pos, m_clone);
		}
		public void Finish()
		{
			m_endPoint = GetPoint(m_pointId);
			m_owner.P1 = m_clone.P1;
			m_owner.P2 = m_clone.P2;
			m_clone = null;
		}
		public void Cancel()
		{
		}
		public void Undo()
		{
			SetPoint(m_pointId, m_originalPoint, m_owner);
		}
		public void Redo()
		{
			SetPoint(m_pointId, m_endPoint, m_owner);
		}
		public void OnKeyDown(ICanvas canvas, KeyEventArgs e)
		{
            Console.Write(e.KeyCode);

			if (e.KeyCode == Keys.L)
			{
				m_angleLocked = !m_angleLocked;
				e.Handled = true;
			}
		}
		#endregion
		protected UnitPoint GetPoint(ePoint pointid)
		{
			if (pointid == ePoint.P1)
				return m_clone.P1;
			if (pointid == ePoint.P2)
				return m_clone.P2;
			return m_owner.P1;
		}
		protected UnitPoint OtherPoint(ePoint currentpointid)
		{
			if (currentpointid == ePoint.P1)
				return GetPoint(ePoint.P2);
			return GetPoint(ePoint.P1);
		}
		protected void SetPoint(ePoint pointid, UnitPoint point, Line line)
		{
			if (pointid == ePoint.P1)
				line.P1 = point;
			if (pointid == ePoint.P2)
				line.P2 = point;
		}
	}
 
}
