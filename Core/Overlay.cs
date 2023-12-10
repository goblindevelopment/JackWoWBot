using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using GameOverlay;
using GameOverlay.Drawing;
using GameOverlay.Windows;
using Jack.Engine;
using Jack.Forms;
using Jack.Models;
using Jack.Properties;

namespace Jack.Core
{
	// Token: 0x02000109 RID: 265
	public class Overlay : IDisposable
	{
		// Token: 0x060017E7 RID: 6119 RVA: 0x0071DB64 File Offset: 0x0071BD64
		public static void Start()
		{
			TimerService.EnableHighPrecisionTimers();
			using (Overlay overlay = new Overlay())
			{
				overlay.Run();
			}
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0071DBA0 File Offset: 0x0071BDA0
		public Overlay()
		{
			this._brushes = new Dictionary<string, SolidBrush>();
			this._fonts = new Dictionary<string, Font>();
			this._images = new Dictionary<string, Image>();
			Graphics graphics = new Graphics
			{
				PerPrimitiveAntiAliasing = Settings.OverlayGFXAntiAliasing,
				TextAntiAliasing = Settings.OverlayGFXAntiAliasing
			};
			try
			{
				this._window = new StickyWindow(_globals.processHandle, graphics)
				{
					FPS = Settings.OverlayGFXFPS,
					IsTopmost = true,
					IsVisible = true
				};
			}
			catch
			{
				return;
			}
			if (ObjectManager.Me != null)
			{
				this.HasHerbalism = ObjectManager.Me.HasProfession(Constants.Professions.Herbalism);
				this.HasMining = ObjectManager.Me.HasProfession(Constants.Professions.Mining);
				this.HasSkinning = ObjectManager.Me.HasProfession(Constants.Professions.Skinning);
			}
			this._window.DestroyGraphics += this._window_DestroyGraphics;
			this._window.DrawGraphics += this._window_DrawGraphics;
			this._window.SetupGraphics += this._window_SetupGraphics;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0071DD28 File Offset: 0x0071BF28
		private void _window_SetupGraphics(object sender, SetupGraphicsEventArgs e)
		{
			Graphics graphics = e.Graphics;
			if (e.RecreateResources)
			{
				foreach (KeyValuePair<string, SolidBrush> keyValuePair in this._brushes)
				{
					keyValuePair.Value.Dispose();
				}
				foreach (KeyValuePair<string, Image> keyValuePair2 in this._images)
				{
					keyValuePair2.Value.Dispose();
				}
			}
			this._brushes["Black"] = graphics.CreateSolidBrush(0, 0, 0, 255);
			this._brushes["BlackTransparent"] = graphics.CreateSolidBrush(0, 0, 0, 160);
			this._brushes["BlackTransparentFull"] = graphics.CreateSolidBrush(0, 0, 0, 80);
			this._brushes["White"] = graphics.CreateSolidBrush(255, 255, 255, 255);
			this._brushes["WhiteTransparent"] = graphics.CreateSolidBrush(255, 255, 255, 160);
			this._brushes["WhiteTransparentFull"] = graphics.CreateSolidBrush(255, 255, 255, 50);
			this._brushes["Radius"] = graphics.CreateSolidBrush(255, 255, 255, 20);
			this._brushes["Grey"] = graphics.CreateSolidBrush(184, 184, 184, 255);
			this._brushes["Red"] = graphics.CreateSolidBrush(255, 0, 0, 255);
			this._brushes["RedLight"] = graphics.CreateSolidBrush(255, 99, 99, 255);
			this._brushes["Orange"] = graphics.CreateSolidBrush(255, 196, 0, 255);
			this._brushes["Green"] = graphics.CreateSolidBrush(0, 255, 0, 255);
			this._brushes["GreenTransparent"] = graphics.CreateSolidBrush(0, 255, 0, 160);
			this._brushes["GreenTransparentFull"] = graphics.CreateSolidBrush(0, 255, 0, 80);
			this._brushes["Blue"] = graphics.CreateSolidBrush(23, 70, 235, 255);
			this._brushes["BlueLight"] = graphics.CreateSolidBrush(74, 193, 255, 255);
			this._brushes["BlueLightTransparent"] = graphics.CreateSolidBrush(74, 193, 255, 160);
			this._brushes["BlueLightTransparentFull"] = graphics.CreateSolidBrush(74, 193, 255, 80);
			this._brushes["GreenBlue"] = graphics.CreateSolidBrush(3, 252, 207, 255);
			this._brushes["GreenBlueTransparent"] = graphics.CreateSolidBrush(3, 252, 160, 255);
			this._brushes["GreenBlueTransparentFull"] = graphics.CreateSolidBrush(3, 252, 80, 255);
			this._brushes["Yellow"] = graphics.CreateSolidBrush(246, 255, 0, 255);
			this._brushes["Background"] = graphics.CreateSolidBrush(0, 0, 0, 1);
			this._fonts["ArialLarge"] = graphics.CreateFont("Arial", 14f, false, false, false);
			this._fonts["ArialMedium"] = graphics.CreateFont("Arial", 12f, false, false, false);
			this._fonts["ArialSmall"] = graphics.CreateFont("Arial", 10f, false, false, false);
			this._fonts["ConsolasLarge"] = graphics.CreateFont("Consolas", 14f, false, false, false);
			this._fonts["ConsolasMedium"] = graphics.CreateFont("Consolas", 12f, false, false, false);
			this._fonts["ConsolasSmall"] = graphics.CreateFont("Consolas", 10f, false, false, false);
			this._images["JackHead"] = graphics.CreateImage(Tools.ResourceToByteArray(Resources.jack_25));
			this._images["JackHeadBlue"] = graphics.CreateImage(Tools.ResourceToByteArray(Resources.jack_blue_25));
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0071E224 File Offset: 0x0071C424
		private void _window_DestroyGraphics(object sender, DestroyGraphicsEventArgs e)
		{
			foreach (KeyValuePair<string, SolidBrush> keyValuePair in this._brushes)
			{
				keyValuePair.Value.Dispose();
			}
			foreach (KeyValuePair<string, Font> keyValuePair2 in this._fonts)
			{
				keyValuePair2.Value.Dispose();
			}
			foreach (KeyValuePair<string, Image> keyValuePair3 in this._images)
			{
				keyValuePair3.Value.Dispose();
			}
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x0071E310 File Offset: 0x0071C510
		private void _window_DrawGraphics(object sender, DrawGraphicsEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.ClearScene(this._brushes["Background"]);
			if (Overlay.Stop || !_globals.Ready)
			{
				this.Close();
			}
			if ((Window.IsMyHandle || !_globals.WindowEnabled) && ObjectManager.Me != null)
			{
				object lockOverlay = ObjectManager._lockOverlay;
				lock (lockOverlay)
				{
					try
					{
						Vector3 positionVector = ObjectManager.Me.PositionVector3;
						Vector2 myPositionW2S = W2S.Convert(ObjectManager.Me.PositionVector3);
						if (Settings.OverlayWaypoints)
						{
							this.DisplayWaypointsWhileRunning(graphics, positionVector);
							this.DisplayRecordedWaypoints(graphics, positionVector, myPositionW2S);
							if (Overlay.ShowMeshPath)
							{
								this.DisplayMeshPath(graphics, positionVector, myPositionW2S);
							}
							this.DisplayWaypointsMenu(graphics);
						}
						if (Settings.OverlayESPObjectsHerbs)
						{
							this.DisplayESPHerbs(graphics, myPositionW2S);
						}
						if (Settings.OverlayESPObjectsOres)
						{
							this.DisplayESPOres(graphics, myPositionW2S);
						}
						if (Settings.OverlayESPObjectsSkinnables)
						{
							this.DisplayESPSkinnables(graphics, myPositionW2S);
						}
						if (Settings.OverlayESPObjectsGatherableMobs)
						{
							this.DisplayESPGatherableMobs(graphics, myPositionW2S);
						}
						if (Settings.OverlayESPObjectsChests)
						{
							this.DisplayESPChests(graphics, myPositionW2S);
						}
						if (Settings.OverlayESPObjectsContainer)
						{
							this.DisplayESPContainer(graphics, myPositionW2S);
						}
						if (Settings.OverlayESPObjectsFishingPools)
						{
							this.DisplayESPFishingPools(graphics, myPositionW2S);
						}
						if (Settings.OverlayESPObjectsLoots)
						{
							this.DisplayESPLoots(graphics, myPositionW2S);
						}
						if (Settings.OverlayESPUnits)
						{
							if (!(Settings.OverlayESPUnitsType == "All NPC's"))
							{
								this.DisplayESPPlayers(graphics, myPositionW2S);
							}
							else
							{
								this.DisplayESPNPCs(graphics, myPositionW2S);
							}
						}
					}
					catch
					{
					}
				}
				if (!_globals.ShowRecordedProfile)
				{
					if (Settings.OverlayMenuConsole)
					{
						this.ShowConsole(graphics);
					}
					if (Settings.OverlayMenuStartStop && Settings.SelectedProfile != "")
					{
						this.ShowStartStop(graphics);
					}
				}
				if (!_globals.IsPremiumProfile && _globals.ShowRecordedProfile && Settings.OverlayMenuRecorder)
				{
					this.ShowRecorder(graphics);
				}
				if (Overlay.ShowRadius)
				{
					this.DisplayRadius(graphics);
				}
				if (Overlay.ShowRadiusAroundOwnLocation)
				{
					this.DisplayRadiusAroundOwnLocation(graphics);
				}
				if (Overlay.ShowSavedRadius)
				{
					this.DisplaySavedRadii(graphics);
				}
				if (Overlay.ShowGoalList)
				{
					this.DrawGoalByList(graphics);
				}
				if (_globals.TestEnv["OverlayTest"])
				{
					this.ShowTestPath(graphics);
				}
			}
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0071E558 File Offset: 0x0071C758
		private void DisplayWaypointsWhileRunning(Graphics gfx, Vector3 MyPosition)
		{
			Overlay.<>c__DisplayClass17_0 CS$<>8__locals1;
			CS$<>8__locals1.gfx = gfx;
			CS$<>8__locals1.<>4__this = this;
			object @lock = EventManager._lock;
			lock (@lock)
			{
				this.ShowGraphic(CS$<>8__locals1.gfx, "Run");
				this.ShowGraphic(CS$<>8__locals1.gfx, "Mark");
				List<Vector3> waypoints = _globals.Waypoints;
				int count = waypoints.Count;
				int counter = Walk.Counter;
				if (_globals.Start && count > 1 && counter >= 0 && counter < count - 1)
				{
					string key = "WhiteTransparentFull";
					if (Jack.Engine.Monitor.NeedGlobalEvent)
					{
						key = "BlueLight";
					}
					Vector2 vector = W2S.Convert(new Vector3(MyPosition.X, MyPosition.Y, MyPosition.Z - 1f));
					for (int i = 0; i < 3; i++)
					{
						int num = counter + i;
						if (num > count - 1)
						{
							num = 0;
						}
						Vector2 vector2 = W2S.Convert(new Vector3(waypoints[num].X, waypoints[num].Y, waypoints[num].Z - 1f));
						if (vector2.X <= 0f || vector2.Y <= 0f)
						{
							break;
						}
						CS$<>8__locals1.gfx.DashedLine(this._brushes[key], vector.X, vector.Y, vector2.X, vector2.Y, 2f);
						int num2 = 3;
						if (counter < 100)
						{
							if (counter >= 10)
							{
								num2 = 5;
							}
						}
						else
						{
							num2 = 8;
						}
						CS$<>8__locals1.gfx.FillCircle(this._brushes[key], vector2.X, vector2.Y, 8f);
						CS$<>8__locals1.gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["Black"], vector2.X - (float)num2, vector2.Y - 6f, (num + 1).ToString());
						this.method_0(waypoints[num], vector2, ref CS$<>8__locals1);
						vector = W2S.Convert(new Vector3(waypoints[num].X, waypoints[num].Y, waypoints[num].Z - 1f));
					}
				}
			}
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0071E7E0 File Offset: 0x0071C9E0
		private void DisplayRecordedWaypoints(Graphics gfx, Vector3 MyPosition, Vector2 MyPositionW2S)
		{
			if (_globals.Start)
			{
				return;
			}
			if (!_globals.Record && !_globals.ShowProfile && !_globals.ShowRecordedProfile && !frmProfileEvent.RecordingEventRoute)
			{
				return;
			}
			object @lock = frmProfile._lock;
			lock (@lock)
			{
				object lock2 = frmProfileEvent._lock;
				lock (lock2)
				{
					this.ShowGraphic(gfx, "Record");
					int num = 0;
					List<Vector3> list;
					List<Events> list2;
					if (frmProfileEvent.RecordingEventRoute)
					{
						list = frmProfileEvent.RecordedEventWaypoints;
						list2 = frmProfile.RecordedEvents;
					}
					else if (!_globals.Record && !_globals.ShowRecordedProfile)
					{
						list = _globals.Waypoints;
						list2 = _globals.Events;
					}
					else
					{
						list = frmProfile.RecordedWaypoints;
						list2 = frmProfile.RecordedEvents;
						if (list.Count > Settings.RecorderShowMaxLastWaypoints + 1)
						{
							num = list.Count - Settings.RecorderShowMaxLastWaypoints;
						}
					}
					if (list.Count > 0)
					{
						string text = "";
						int num2 = 0;
						bool flag3 = false;
						Vector2 vector = W2S.Convert(list.FirstOrDefault<Vector3>());
						if (list.Count > 1)
						{
							if (!_globals.IsInDungeon && vector.X > 0f && vector.Y > 0f)
							{
								this.DrawHoverCircle(gfx, vector.X, vector.Y, 8, 15, "GreenTransparent", 0, list.FirstOrDefault<Vector3>());
							}
							for (int i = 0; i < list.Count; i++)
							{
								if (JackMath.Distance(list[i], true, true, true) <= (double)Settings.OverlayWaypointsDisplayRadius && (i == 0 || i >= num))
								{
									Vector2 vector2 = W2S.Convert(list[i]);
									Vector2 vector3;
									if (i >= list.Count - 1)
									{
										flag3 = true;
										vector3 = MyPositionW2S;
									}
									else
									{
										vector3 = W2S.Convert(list[i + 1]);
									}
									if (vector2.X > 0f && vector2.Y > 0f && vector3.X > 0f && vector3.Y > 0f)
									{
										string color = "WhiteTransparent";
										int sizeOuter = 15;
										if (frmProfile.SelectedWaypoints.Contains(i))
										{
											color = "Orange";
											sizeOuter = 20;
										}
										if (list2.Count > 0)
										{
											int num3 = 1;
											num2 = 0;
											text = "";
											foreach (Events events in list2)
											{
												if (events.Vector3 == list[i])
												{
													color = "BlueLight";
													num2 += 30;
													if (num3 != 1)
													{
														text = string.Concat(new string[]
														{
															text,
															"\r\n",
															num3.ToString(),
															". ",
															events.Name
														});
													}
													else
													{
														text = string.Concat(new string[]
														{
															text,
															"  # EVENT(S) #\r\n",
															num3.ToString(),
															". ",
															events.Name
														});
													}
													num3++;
												}
											}
										}
										if (!flag3 && (num == 0 || (num > 0 && i >= num)))
										{
											gfx.DashedLine(this._brushes["WhiteTransparent"], vector2.X, vector2.Y, vector3.X, vector3.Y, 2f);
										}
										if (i == 0)
										{
											this.DrawHoverCircle(gfx, vector2.X, vector2.Y, 8, sizeOuter, "GreenTransparent", i, list[i]);
										}
										else
										{
											this.DrawHoverCircle(gfx, vector2.X, vector2.Y, 8, sizeOuter, color, i, list[i]);
										}
										if (text.Length > 0)
										{
											gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector2.X + 18f, vector2.Y - (float)num2, text);
											gfx.DrawImage(this._images["JackHeadBlue"], vector2.X + 4f, vector2.Y - (float)num2 - 15f, 1f);
										}
										int num4 = 23;
										if (i + 1 < 100)
										{
											if (i + 1 >= 10)
											{
												num4 = 25;
											}
										}
										else
										{
											num4 = 28;
										}
										gfx.FillCircle(this._brushes["WhiteTransparent"], vector2.X - 20f, vector2.Y + 20f, 8f);
										gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["Black"], vector2.X - (float)num4, vector2.Y + 14f, (i + 1).ToString());
									}
								}
							}
							if (!_globals.ShowProfile && list.Count > 2 && JackMath.Distance(list.FirstOrDefault<Vector3>(), true, true, true) <= (double)(Settings.RecorderAutoDistance * 2) && vector.X > 0f && vector.Y > 0f)
							{
								gfx.DashedLine(this._brushes["GreenTransparent"], MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
								gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 30f, Math.Floor(JackMath.Distance(list.FirstOrDefault<Vector3>(), true, true, true)).ToString() + " yd");
							}
						}
						else if (vector.X > 0f && vector.Y > 0f)
						{
							this.DrawHoverCircle(gfx, vector.X, vector.Y, 8, 15, "GreenTransparent", 0, list.FirstOrDefault<Vector3>());
						}
						if (!_globals.ShowProfile)
						{
							if (!Settings.RecorderAutoRecord)
							{
								Overlay.RecorderInfo = "[Manual] " + Math.Floor(JackMath.Distance(list.LastOrDefault<Vector3>(), true, true, true)).ToString() + " yds";
							}
							else
							{
								Overlay.RecorderInfo = string.Concat(new string[]
								{
									"[Auto] ",
									Math.Floor(JackMath.Distance(list.LastOrDefault<Vector3>(), true, true, true)).ToString(),
									"/",
									Settings.RecorderAutoDistance.ToString(),
									" yds"
								});
							}
						}
						else
						{
							Overlay.RecorderInfo = "";
							List<Vector3> list3 = list.ToList<Vector3>();
							if (list3.Count > 0)
							{
								int closestCrd = Walk.GetClosestCrd(list3);
								Vector2 vector4 = W2S.Convert(list3[closestCrd]);
								double num5 = JackMath.Distance(list3[closestCrd], true, true, true);
								if (vector4.X > 0f && vector4.Y > 0f && num5 > 50.0)
								{
									gfx.DashedLine(this._brushes["BlueLightTransparent"], MyPositionW2S.X, MyPositionW2S.Y, vector4.X, vector4.Y, 2f);
								}
								Overlay.ConsoleInfo = Settings.SelectedProfile + " (" + Math.Floor(num5).ToString() + " yds)";
							}
						}
					}
				}
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0071EFD8 File Offset: 0x0071D1D8
		private void DisplayWaypointsMenu(Graphics gfx)
		{
			if (!_globals.Start && _globals.ShowOverlayMenuProfilePreview)
			{
				object lockWaypoints = frmOverlayMenu._lockWaypoints;
				lock (lockWaypoints)
				{
					int count = _globals.WaypointsOverlayMenuPreview.Count;
					Vector2 vector = default(Vector2);
					Vector2 vector2 = default(Vector2);
					for (int i = 0; i < count; i++)
					{
						vector = W2S.Convert(_globals.WaypointsOverlayMenuPreview[i]);
						if (i == count - 1)
						{
							vector2 = W2S.Convert(_globals.WaypointsOverlayMenuPreview[0]);
						}
						else
						{
							vector2 = W2S.Convert(_globals.WaypointsOverlayMenuPreview[i + 1]);
						}
						if (vector.X > 0f && vector.Y > 0f && vector2.X > 0f && vector2.Y > 0f)
						{
							if (i == 0)
							{
								gfx.DrawLine(this._brushes["Orange"], vector.X, vector.Y, vector2.X, vector2.Y, 2f);
								gfx.FillCircle(this._brushes["Green"], vector.X, vector.Y, 6f);
								gfx.DashedCircle(this._brushes["Green"], vector.X, vector.Y, 10f, 2f);
							}
							else
							{
								gfx.DrawLine(this._brushes["Orange"], vector.X, vector.Y, vector2.X, vector2.Y, 2f);
								gfx.FillCircle(this._brushes["Orange"], vector.X, vector.Y, 3f);
								gfx.DashedCircle(this._brushes["Orange"], vector.X, vector.Y, 7f, 2f);
							}
						}
					}
				}
				return;
			}
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x0071F204 File Offset: 0x0071D404
		private void DisplayESPHerbs(Graphics gfx, Vector2 MyPositionW2S)
		{
			foreach (Objects objects in ObjectManager.GetHerbsOverlay)
			{
				if (!_globals.Ready && !_globals.Record)
				{
					break;
				}
				if (objects != null)
				{
					Vector2 vector = W2S.Convert(objects.PositionVector3);
					if (vector.X > 0f && vector.Y > 0f)
					{
						double num = JackMath.Distance(objects.PositionVector3, true, true, true);
						if (num <= (double)Settings.OverlayESPObjectsDistance)
						{
							SolidBrush solidBrush = this._brushes["GreenTransparentFull"];
							if (Walk.CheckProfileSettings && num <= (double)Walk.ProfileSettings.DistanceLoot)
							{
								solidBrush = this._brushes["Green"];
							}
							gfx.DrawLine(solidBrush, MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
							gfx.FillCircle(solidBrush, vector.X, vector.Y, 5f);
							string text = objects.Name + " (" + Math.Floor(num).ToString() + " yd)";
							string text2 = "Required Skill: " + _globals.List_Herbalism[objects.ItemID].ToString();
							if (this.HasHerbalism)
							{
								gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 50f, text);
								gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 30f, text2);
							}
							else
							{
								string text3 = "Requires Herbalism";
								gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Grey"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
								gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
								gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Red"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
							}
						}
					}
				}
			}
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x0071F514 File Offset: 0x0071D714
		private void DisplayESPOres(Graphics gfx, Vector2 MyPositionW2S)
		{
			foreach (Objects objects in ObjectManager.GetOresOverlay)
			{
				if (!_globals.Ready && !_globals.Record)
				{
					break;
				}
				if (objects != null)
				{
					Vector2 vector = W2S.Convert(objects.PositionVector3);
					if (vector.X > 0f && vector.Y > 0f)
					{
						double num = JackMath.Distance(objects.PositionVector3, true, true, true);
						if (num <= (double)Settings.OverlayESPObjectsDistance)
						{
							SolidBrush solidBrush = this._brushes["GreenTransparentFull"];
							if (Walk.CheckProfileSettings && num <= (double)Walk.ProfileSettings.DistanceLoot)
							{
								solidBrush = this._brushes["Green"];
							}
							gfx.DrawLine(solidBrush, MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
							gfx.FillCircle(solidBrush, vector.X, vector.Y, 5f);
							string text = objects.Name + " (" + Math.Floor(num).ToString() + " yd)";
							string text2 = "Required Skill: " + _globals.List_Mining[objects.ItemID].ToString();
							if (!this.HasMining)
							{
								string text3 = "Requires Mining";
								gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Grey"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
								gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
								gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Red"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
							}
							else
							{
								gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 50f, text);
								gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 30f, text2);
							}
						}
					}
				}
			}
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0071F824 File Offset: 0x0071DA24
		private void DisplayESPSkinnables(Graphics gfx, Vector2 MyPositionW2S)
		{
			foreach (Units units in ObjectManager.GetSkinsOverlay)
			{
				if (!_globals.Ready && !_globals.Record)
				{
					break;
				}
				if (units != null)
				{
					Vector2 vector = W2S.Convert(units.PositionVector3);
					if (vector.X > 0f && vector.Y > 0f)
					{
						bool flag = this.HashListMineableMobs.Contains(units.DisplayID);
						bool flag2 = false;
						if (!flag)
						{
							flag2 = this.HashListHerbableMobs.Contains(units.DisplayID);
						}
						if (!flag && !flag2)
						{
							double num = JackMath.Distance(units.PositionVector3, true, true, true);
							if (num <= (double)Settings.OverlayESPObjectsDistance)
							{
								SolidBrush solidBrush = this._brushes["GreenTransparentFull"];
								if (Walk.CheckProfileSettings && num <= (double)Walk.ProfileSettings.DistanceLoot)
								{
									solidBrush = this._brushes["Green"];
								}
								gfx.DrawLine(solidBrush, MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
								gfx.FillCircle(solidBrush, vector.X, vector.Y, 5f);
								string text = units.Name + " (" + Math.Floor(num).ToString() + " yd)";
								string text2 = "Level " + units.Level.ToString();
								string text3 = "Skinnable";
								if (this.HasSkinning)
								{
									gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
									gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
									gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
								}
								else
								{
									text3 = "Requires Skinning";
									gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Grey"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
									gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
									gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Red"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x0071FBA8 File Offset: 0x0071DDA8
		private void DisplayESPGatherableMobs(Graphics gfx, Vector2 MyPositionW2S)
		{
			foreach (Units units in ObjectManager.GetSkinsOverlay)
			{
				if (!_globals.Ready && !_globals.Record)
				{
					break;
				}
				if (units != null)
				{
					Vector2 vector = W2S.Convert(units.PositionVector3);
					if (vector.X > 0f && vector.Y > 0f)
					{
						bool flag = this.HashListMineableMobs.Contains(units.DisplayID);
						bool flag2 = false;
						if (!flag)
						{
							flag2 = this.HashListHerbableMobs.Contains(units.DisplayID);
						}
						if (flag || flag2)
						{
							double num = JackMath.Distance(units.PositionVector3, true, true, true);
							if (num <= (double)Settings.OverlayESPObjectsDistance)
							{
								SolidBrush solidBrush = this._brushes["GreenTransparentFull"];
								if (Walk.CheckProfileSettings && num <= (double)Walk.ProfileSettings.DistanceLoot)
								{
									solidBrush = this._brushes["Green"];
								}
								gfx.DrawLine(solidBrush, MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
								gfx.FillCircle(solidBrush, vector.X, vector.Y, 5f);
								string text = units.Name + " (" + Math.Floor(num).ToString() + " yd)";
								string text2 = "Level " + units.Level.ToString();
								string text3 = "Mineable";
								if (flag2)
								{
									text3 = "Herbable";
								}
								if (!flag)
								{
									if (flag2)
									{
										if (this.HasHerbalism)
										{
											gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
											gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
											gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
										}
										else
										{
											text3 = "Requires Herbalism";
											gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Grey"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
											gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
											gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Red"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
										}
									}
								}
								else if (!this.HasMining)
								{
									text3 = "Requires Mining";
									gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Grey"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
									gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
									gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Red"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
								}
								else
								{
									gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
									gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
									gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00720124 File Offset: 0x0071E324
		private void DisplayESPChests(Graphics gfx, Vector2 MyPositionW2S)
		{
			foreach (Objects objects in ObjectManager.GetChestsOverlay)
			{
				if (!_globals.Ready && !_globals.Record)
				{
					break;
				}
				if (objects != null)
				{
					Vector2 vector = W2S.Convert(objects.PositionVector3);
					if (vector.X > 0f && vector.Y > 0f)
					{
						double num = JackMath.Distance(objects.PositionVector3, true, true, true);
						if (num <= (double)Settings.OverlayESPObjectsDistance)
						{
							SolidBrush solidBrush = this._brushes["GreenTransparentFull"];
							if (Walk.CheckProfileSettings && num <= (double)Walk.ProfileSettings.DistanceLoot)
							{
								solidBrush = this._brushes["Green"];
							}
							gfx.DrawLine(solidBrush, MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
							gfx.FillCircle(solidBrush, vector.X, vector.Y, 5f);
							string text = objects.Name + " (" + Math.Floor(num).ToString() + " yd)";
							gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 50f, text);
							if (!_globals.IsRetail)
							{
								if (objects.IsLocked)
								{
									gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["Red"], this._brushes["Black"], vector.X, vector.Y - 30f, "Locked");
								}
								else
								{
									gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 30f, "Open");
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00720378 File Offset: 0x0071E578
		private void DisplayESPContainer(Graphics gfx, Vector2 MyPositionW2S)
		{
			foreach (Objects objects in ObjectManager.GetContainerOverlay)
			{
				if (!_globals.Ready && !_globals.Record)
				{
					break;
				}
				if (objects != null)
				{
					Vector2 vector = W2S.Convert(objects.PositionVector3);
					if (vector.X > 0f && vector.Y > 0f)
					{
						double num = JackMath.Distance(objects.PositionVector3, true, true, true);
						if (num <= (double)Settings.OverlayESPObjectsDistance)
						{
							SolidBrush solidBrush = this._brushes["GreenTransparentFull"];
							if (Walk.CheckProfileSettings && num <= (double)Walk.ProfileSettings.DistanceLoot)
							{
								solidBrush = this._brushes["Green"];
							}
							gfx.DrawLine(solidBrush, MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
							gfx.FillCircle(solidBrush, vector.X, vector.Y, 5f);
							string text = objects.Name + " (" + Math.Floor(num).ToString() + " yd)";
							gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
						}
					}
				}
			}
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00720520 File Offset: 0x0071E720
		private void DisplayESPFishingPools(Graphics gfx, Vector2 MyPositionW2S)
		{
			foreach (Objects objects in ObjectManager.GetFishingPoolsOverlay)
			{
				if (!_globals.Ready && !_globals.Record)
				{
					break;
				}
				if (objects != null)
				{
					Vector2 vector = W2S.Convert(objects.PositionVector3);
					if (vector.X > 0f && vector.Y > 0f)
					{
						double num = JackMath.Distance(objects.PositionVector3, true, true, true);
						if (num <= (double)Settings.OverlayESPObjectsDistance)
						{
							SolidBrush solidBrush = this._brushes["GreenTransparentFull"];
							if (Walk.CheckProfileSettings && num <= (double)Walk.ProfileSettings.DistanceLoot)
							{
								solidBrush = this._brushes["Green"];
							}
							gfx.DrawLine(solidBrush, MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
							gfx.FillCircle(solidBrush, vector.X, vector.Y, 5f);
							string text = objects.Name + " (" + Math.Floor(num).ToString() + " yd)";
							gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
						}
					}
				}
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x007206C8 File Offset: 0x0071E8C8
		private void DisplayESPLoots(Graphics gfx, Vector2 MyPositionW2S)
		{
			foreach (Units units in ObjectManager.GetLootsOverlay)
			{
				if (!_globals.Ready && !_globals.Record)
				{
					break;
				}
				if (units != null)
				{
					Vector2 vector = W2S.Convert(units.PositionVector3);
					if (vector.X > 0f && vector.Y > 0f)
					{
						double num = JackMath.Distance(units.PositionVector3, true, true, true);
						if (num <= (double)Settings.OverlayESPObjectsDistance)
						{
							SolidBrush solidBrush = this._brushes["GreenTransparentFull"];
							if (Walk.CheckProfileSettings && num <= (double)Walk.ProfileSettings.DistanceLoot)
							{
								solidBrush = this._brushes["Green"];
							}
							gfx.DrawLine(solidBrush, MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
							gfx.FillCircle(solidBrush, vector.X, vector.Y, 5f);
							string text = units.Name + " (" + Math.Floor(num).ToString() + " yd)";
							string text2 = "Level " + units.Level.ToString();
							string text3 = "Lootable";
							gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
							gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
							gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
						}
					}
				}
			}
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00720924 File Offset: 0x0071EB24
		private void DisplayESPNPCs(Graphics gfx, Vector2 MyPositionW2S)
		{
			foreach (Units units in ObjectManager.GetNPCsOverlay)
			{
				if (!_globals.Ready && !_globals.Record)
				{
					break;
				}
				if (units != null)
				{
					Vector2 vector = W2S.Convert(units.PositionVector3);
					if (vector.X > 0f && vector.Y > 0f)
					{
						bool isDead = units.IsDead;
						bool isLootable = units.IsLootable;
						bool isSkinnable = units.IsSkinnable;
						if (!isDead || isLootable)
						{
							double num = JackMath.Distance(units.PositionVector3, true, true, true);
							if (num <= (double)Settings.OverlayESPUnitsDistance)
							{
								SolidBrush solidBrush = this._brushes["GreenBlue"];
								if (isLootable || isSkinnable)
								{
									solidBrush = this._brushes["Green"];
								}
								gfx.DrawLine(solidBrush, MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
								gfx.FillCircle(solidBrush, vector.X, vector.Y, 5f);
								string text = units.Name + " (" + Math.Floor(num).ToString() + " yd)";
								string text2 = "Level " + units.Level.ToString();
								if (units.IsElite)
								{
									text2 += " (*ELITE*)";
								}
								if (!isLootable && (!this.HasSkinning || !isSkinnable))
								{
									string text3 = units.CreatureType.ToString();
									gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
									gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
									gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Grey"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
								}
								else
								{
									string text3 = "Lootable";
									if (isSkinnable)
									{
										text3 = "Skinnable";
									}
									gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Grey"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
									gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["Grey"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
									gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00720CC8 File Offset: 0x0071EEC8
		private void DisplayESPPlayers(Graphics gfx, Vector2 MyPositionW2S)
		{
			List<Player> list;
			if (Settings.OverlayESPUnitsType == "Horde")
			{
				list = ObjectManager.GetPlayersHordeOverlay;
			}
			else if (!(Settings.OverlayESPUnitsType == "Alliance"))
			{
				list = ObjectManager.GetPlayersOverlay;
			}
			else
			{
				list = ObjectManager.GetPlayersAllianceOverlay;
			}
			foreach (Player player in list)
			{
				if (!_globals.Ready && !_globals.Record)
				{
					break;
				}
				if (player != null)
				{
					Vector2 vector = W2S.Convert(player.PositionVector3);
					if (vector.X > 0f && vector.Y > 0f && !player.IsDead)
					{
						double num = JackMath.Distance(player.PositionVector3, true, true, true);
						if (num <= (double)Settings.OverlayESPUnitsDistance)
						{
							SolidBrush solidBrush = this._brushes["Green"];
							string faction = ObjectManager.Me.Faction;
							string faction2 = player.Faction;
							bool isTargetingMe = player.IsTargetingMe;
							bool isGhost;
							if (isGhost = player.IsGhost)
							{
								solidBrush = this._brushes["Grey"];
							}
							else if (!(faction != faction2))
							{
								if (isTargetingMe)
								{
									solidBrush = this._brushes["Orange"];
								}
							}
							else if (isTargetingMe)
							{
								solidBrush = this._brushes["Red"];
							}
							else
							{
								solidBrush = this._brushes["RedLight"];
							}
							gfx.DrawLine(solidBrush, MyPositionW2S.X, MyPositionW2S.Y, vector.X, vector.Y, 2f);
							gfx.FillCircle(solidBrush, vector.X, vector.Y, 5f);
							string text = player.PlayerName + " (" + Math.Floor(num).ToString() + " yd)";
							string text2 = string.Concat(new string[]
							{
								"Level ",
								player.Level.ToString(),
								" (",
								faction2,
								"/",
								player.Class.ToString(),
								")"
							});
							if (isGhost)
							{
								string text3 = "Ghost";
								gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Grey"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
								gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["Grey"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
								gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 21f, text3);
							}
							else if (!(faction != faction2))
							{
								if (!isTargetingMe)
								{
									gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector.X, vector.Y - 50f, text);
									gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 30f, text2);
								}
								else
								{
									string text4 = "Has you in Target!";
									gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Orange"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
									gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
									gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["RedLight"], this._brushes["Black"], vector.X, vector.Y - 21f, text4);
								}
							}
							else if (isTargetingMe)
							{
								string text5 = "Has you in Target!";
								gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Red"], this._brushes["Black"], vector.X, vector.Y - 60f, text);
								gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 40f, text2);
								gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["Red"], this._brushes["Black"], vector.X, vector.Y - 21f, text5);
							}
							else
							{
								gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["RedLight"], this._brushes["Black"], vector.X, vector.Y - 50f, text);
								gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector.X, vector.Y - 30f, text2);
							}
						}
					}
				}
			}
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00721330 File Offset: 0x0071F530
		private void DisplayMeshPath(Graphics gfx, Vector3 MyPosition, Vector2 MyPositionW2S)
		{
			Overlay.MeshPath = Overlay.MeshPath.ToList<Vector3>();
			if (Overlay.MeshPath.Count == 0)
			{
				return;
			}
			this.DrawGoal(gfx, Overlay.MeshPath.LastOrDefault<Vector3>(), "");
			int num = -1;
			foreach (Vector3 vector in Overlay.MeshPath)
			{
				num++;
				Vector2 vector2 = W2S.Convert(new Vector3(vector.X, vector.Y, vector.Z - 1f));
				if (vector2.X > 0f && vector2.Y > 0f && num + 1 <= Overlay.MeshPath.Count - 1 && JackMath.Distance(MyPosition, vector, true, true, true) <= 50.0 && !JackMath.IsBehind(vector, false))
				{
					Vector2 vector3 = W2S.Convert(new Vector3(Overlay.MeshPath[num + 1].X, Overlay.MeshPath[num + 1].Y, Overlay.MeshPath[num + 1].Z - 1f));
					if (vector3.X > 0f && vector3.Y > 0f)
					{
						gfx.DashedLine(this._brushes["GreenBlueTransparentFull"], vector2.X, vector2.Y, vector3.X, vector3.Y, 2f);
					}
				}
			}
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x007214DC File Offset: 0x0071F6DC
		private void ShowTestPath(Graphics gfx)
		{
			Overlay.TestPath = Overlay.TestPath.ToList<Vector3>();
			if (Overlay.TestPath.Count != 0)
			{
				int num = -1;
				foreach (Vector3 pos in Overlay.TestPath)
				{
					num++;
					Vector2 vector = W2S.Convert(pos);
					if (vector.X > 0f && vector.Y > 0f)
					{
						gfx.FillCircle(this._brushes["GreenBlueTransparentFull"], vector.X, vector.Y, 4f);
						gfx.DashedCircle(this._brushes["GreenBlueTransparentFull"], vector.X, vector.Y, 8f, 2f);
						if (num + 1 <= Overlay.TestPath.Count - 1)
						{
							Vector2 vector2 = W2S.Convert(Overlay.TestPath[num + 1]);
							if (vector2.X > 0f && vector2.Y > 0f)
							{
								gfx.DashedLine(this._brushes["GreenBlueTransparentFull"], vector.X, vector.Y, vector2.X, vector2.Y, 2f);
							}
						}
					}
				}
				return;
			}
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00721648 File Offset: 0x0071F848
		private void DisplayRadius(Graphics gfx)
		{
			List<StuckPaths> list = Overlay.RadiusClickedSelection.ToList<StuckPaths>();
			if (Overlay.RadiusHover != Vector3.Zero)
			{
				Vector2 vector = Vector2.Zero;
				int num = -1;
				for (double num2 = 0.0; num2 < 3.141592653589793 * (double)Overlay.RadiusDivision; num2 += Overlay.RadiusAngle)
				{
					num++;
					Vector2 vector2 = W2S.Convert(new Vector3
					{
						X = (float)((double)Overlay.RadiusHover.X + (double)Overlay.RadiusRadius * Math.Cos(num2 + (double)Overlay.RadiusRotation)),
						Y = (float)((double)Overlay.RadiusHover.Y + (double)Overlay.RadiusRadius * Math.Sin(num2 + (double)Overlay.RadiusRotation)),
						Z = Overlay.RadiusHover.Z
					});
					if (vector == Vector2.Zero)
					{
						vector = vector2;
					}
					else
					{
						if (vector.X > 0f && vector.Y > 0f && vector2.X > 0f && vector2.Y > 0f)
						{
							gfx.DrawLine(this._brushes["White"], vector.X, vector.Y, vector2.X, vector2.Y, 2f);
						}
						vector = vector2;
					}
					gfx.FillCircle(this._brushes["White"], vector2.X, vector2.Y, 4f);
				}
			}
			if (Overlay.RadiusClickedSelection.Count > 0)
			{
				foreach (StuckPaths stuckPaths in list)
				{
					if (stuckPaths.ZoneID == PlayerMe.ZoneID)
					{
						Vector2 vector3 = Vector2.Zero;
						int num3 = -1;
						for (double num4 = 0.0; num4 < 3.141592653589793 * (double)stuckPaths.Division; num4 += stuckPaths.Angle)
						{
							num3++;
							Vector2 vector4 = W2S.Convert(new Vector3
							{
								X = (float)((double)stuckPaths.Location.X + (double)stuckPaths.Radius * Math.Cos(num4 + (double)stuckPaths.Rotation)),
								Y = (float)((double)stuckPaths.Location.Y + (double)stuckPaths.Radius * Math.Sin(num4 + (double)stuckPaths.Rotation)),
								Z = stuckPaths.Location.Z
							});
							if (vector3 == Vector2.Zero)
							{
								vector3 = vector4;
							}
							else
							{
								if (vector3.X > 0f && vector3.Y > 0f && vector4.X > 0f && vector4.Y > 0f)
								{
									gfx.DrawLine(this._brushes["Blue"], vector3.X, vector3.Y, vector4.X, vector4.Y, 2f);
								}
								vector3 = vector4;
							}
							gfx.FillCircle(this._brushes["Blue"], vector4.X, vector4.Y, 4f);
						}
						Vector2 vector5 = W2S.Convert(stuckPaths.Location);
						string text = stuckPaths.Name + " (" + stuckPaths.Type + ")";
						gfx.FillCircle(this._brushes["Orange"], vector5.X, vector5.Y - 40f, 4f);
						gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector5.X, vector5.Y - 62f, text);
					}
				}
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00721A5C File Offset: 0x0071FC5C
		private void DisplayRadiusAroundOwnLocation(Graphics gfx)
		{
			Vector3 positionVector = ObjectManager.Me.PositionVector3;
			Vector2 vector = Vector2.Zero;
			int num = -1;
			for (double num2 = 0.0; num2 < 3.141592653589793 * (double)Overlay.RadiusDivision; num2 += Overlay.RadiusAngle)
			{
				num++;
				Vector2 vector2 = W2S.Convert(new Vector3
				{
					X = (float)((double)positionVector.X + (double)Overlay.RadiusRadius * Math.Cos(num2 + (double)Overlay.RadiusRotation)),
					Y = (float)((double)positionVector.Y + (double)Overlay.RadiusRadius * Math.Sin(num2 + (double)Overlay.RadiusRotation)),
					Z = positionVector.Z
				});
				if (vector == Vector2.Zero)
				{
					vector = vector2;
				}
				else
				{
					if (vector.X > 0f && vector.Y > 0f && vector2.X > 0f && vector2.Y > 0f)
					{
						gfx.DrawLine(this._brushes["White"], vector.X, vector.Y, vector2.X, vector2.Y, 2f);
					}
					vector = vector2;
				}
				gfx.FillCircle(this._brushes["White"], vector2.X, vector2.Y, 4f);
			}
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00721BC0 File Offset: 0x0071FDC0
		private void DisplaySavedRadii(Graphics gfx)
		{
			if (Overlay.SavedRadiusLocation == Vector3.Zero)
			{
				return;
			}
			Vector2 vector = Vector2.Zero;
			int num = -1;
			for (double num2 = 0.0; num2 < 3.141592653589793 * (double)Overlay.SavedRadiusDivision; num2 += Overlay.SavedRadiusAngle)
			{
				num++;
				Vector2 vector2 = W2S.Convert(new Vector3
				{
					X = (float)((double)Overlay.SavedRadiusLocation.X + (double)Overlay.SavedRadiusRadius * Math.Cos(num2 + (double)Overlay.SavedRadiusRotation)),
					Y = (float)((double)Overlay.SavedRadiusLocation.Y + (double)Overlay.SavedRadiusRadius * Math.Sin(num2 + (double)Overlay.SavedRadiusRotation)),
					Z = Overlay.SavedRadiusLocation.Z
				});
				if (!(vector == Vector2.Zero))
				{
					if (vector.X > 0f && vector.Y > 0f && vector2.X > 0f && vector2.Y > 0f)
					{
						gfx.DrawLine(this._brushes["Green"], vector.X, vector.Y, vector2.X, vector2.Y, 2f);
					}
					vector = vector2;
				}
				else
				{
					vector = vector2;
				}
				gfx.FillCircle(this._brushes["Green"], vector2.X, vector2.Y, 4f);
			}
			Vector2 vector3 = W2S.Convert(Overlay.SavedRadiusLocation);
			string savedRadiusName = Overlay.SavedRadiusName;
			gfx.FillCircle(this._brushes["Orange"], vector3.X, vector3.Y - 40f, 4f);
			gfx.DrawTextWithBackground(this._fonts["ConsolasMedium"], this._brushes["White"], this._brushes["Black"], vector3.X, vector3.Y - 62f, savedRadiusName);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00721DC4 File Offset: 0x0071FFC4
		private void DrawGoal(Graphics gfx, Vector3 GoalLocation, string Info = "")
		{
			Vector2 vector = W2S.Convert(GoalLocation);
			string text = " " + JackMath.Distance(ObjectManager.Me.PositionVector3, GoalLocation, true, true, true).ToString() + " yds";
			if (Info.Length > 0)
			{
				text = string.Concat(new string[]
				{
					" ",
					Info,
					" (",
					text.Trim(),
					")"
				});
			}
			gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["White"], this._brushes["Black"], vector.X + 18f, vector.Y - 13f, text);
			gfx.DrawImage(this._images["JackHead"], vector.X, vector.Y - 20f, 1f);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00721EBC File Offset: 0x007200BC
		private void DrawGoalByList(Graphics gfx)
		{
			List<KeyValuePair<Vector3, string>> list = Overlay.GoalList.ToList<KeyValuePair<Vector3, string>>();
			if (list.Count == 0)
			{
				return;
			}
			foreach (KeyValuePair<Vector3, string> keyValuePair in list)
			{
				Vector2 vector = W2S.Convert(keyValuePair.Key);
				string text = " " + JackMath.Distance(ObjectManager.Me.PositionVector3, keyValuePair.Key, true, true, true).ToString() + " yds";
				if (keyValuePair.Value.Length > 0)
				{
					text = string.Concat(new string[]
					{
						" ",
						keyValuePair.Value,
						" (",
						text.Trim(),
						")"
					});
				}
				gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["White"], this._brushes["Black"], vector.X + 18f, vector.Y - 13f, text);
				gfx.DrawImage(this._images["JackHead"], vector.X, vector.Y - 20f, 1f);
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x00722030 File Offset: 0x00720230
		// (set) Token: 0x06001801 RID: 6145 RVA: 0x00722044 File Offset: 0x00720244
		private static Dictionary<string, object[]> DisplayMode { get; set; }

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x00722058 File Offset: 0x00720258
		// (set) Token: 0x06001803 RID: 6147 RVA: 0x0072206C File Offset: 0x0072026C
		private static Dictionary<string, bool> DisplayModeUpdate { get; set; }

		// Token: 0x06001804 RID: 6148 RVA: 0x00722080 File Offset: 0x00720280
		public static void SetGraphic(Vector3 From, Vector3 To, string Mode, string Color = "WhiteTransparent", string Info = "", bool Update = false)
		{
			if (Overlay.DisplayMode.Keys.Contains(Mode))
			{
				if (Update)
				{
					new Thread(delegate()
					{
						Overlay.UpdateGraphic(To, Mode, Color, Info);
					})
					{
						IsBackground = true
					}.Start();
					return;
				}
				Overlay.DisplayMode[Mode] = new object[]
				{
					W2S.Convert(From),
					W2S.Convert(To),
					Color,
					Info
				};
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00722134 File Offset: 0x00720334
		private static void UpdateGraphic(Vector3 To, string Mode, string Color, string Info)
		{
			while (Overlay.DisplayModeUpdate[Mode])
			{
				Overlay.ClearGraphic(Mode);
				Thread.Sleep(10);
			}
			Overlay.DisplayMode[Mode] = new object[]
			{
				W2S.Convert(ObjectManager.Me.PositionVector3),
				W2S.Convert(To),
				Color,
				Info
			};
			Overlay.DisplayModeUpdate[Mode] = true;
			while (Overlay.DisplayMode[Mode] != null)
			{
				Overlay.DisplayMode[Mode] = new object[]
				{
					W2S.Convert(ObjectManager.Me.PositionVector3),
					W2S.Convert(To),
					Color,
					Info
				};
				Thread.Sleep(10);
			}
			Overlay.DisplayModeUpdate[Mode] = false;
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00722208 File Offset: 0x00720408
		public static void ClearGraphic(string Mode)
		{
			Overlay.DisplayMode[Mode] = null;
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00722224 File Offset: 0x00720424
		public void ShowGraphic(Graphics gfx, string Mode)
		{
			if (Overlay.DisplayMode[Mode] != null)
			{
				Vector2 vector = (Vector2)Overlay.DisplayMode[Mode][0];
				Vector2 vector2 = (Vector2)Overlay.DisplayMode[Mode][1];
				string text = (string)Overlay.DisplayMode[Mode][2];
				string text2 = (string)Overlay.DisplayMode[Mode][3];
				if (Mode == "Run")
				{
					if (vector.X > 0f && vector.Y > 0f)
					{
						gfx.FillCircle(this._brushes["GreenTransparent"], vector.X, vector.Y, 8f);
						if (vector2.X > 0f && vector2.Y > 0f)
						{
							gfx.DashedLine(this._brushes[text], vector.X, vector.Y, vector2.X, vector2.Y, 2f);
							return;
						}
					}
				}
				else if (vector2.X > 0f && vector2.Y > 0f)
				{
					if (Mode == "Global")
					{
						this.ShowAnimatedArrow(gfx, vector2, 0f, 70f, "Top", text);
					}
					else
					{
						this.ShowAnimatedArrow(gfx, vector2, 0f, 70f, "Bottom", text);
					}
					if (text2 != "" && !Settings.OverlayESPObjectsHerbs && !Settings.OverlayESPObjectsOres && !Settings.OverlayESPObjectsChests)
					{
						gfx.DrawTextWithBackground(this._fonts["ConsolasLarge"], this._brushes["Green"], this._brushes["Black"], vector2.X + 30f, vector2.Y + 70f, text2);
					}
				}
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x00722404 File Offset: 0x00720604
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x00722418 File Offset: 0x00720618
		private static float AnimationCount { get; set; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x0072242C File Offset: 0x0072062C
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x00722440 File Offset: 0x00720640
		private static bool AnimationMode { get; set; }

		// Token: 0x0600180C RID: 6156 RVA: 0x00722454 File Offset: 0x00720654
		public static void Animation()
		{
			Overlay.AnimationRuns = true;
			for (;;)
			{
				if (Overlay.AnimationMode)
				{
					Overlay.AnimationCount += 0.5f;
					if (Overlay.AnimationCount >= 10f)
					{
						Overlay.AnimationMode = false;
					}
				}
				else
				{
					Overlay.AnimationCount -= 0.5f;
					if (Overlay.AnimationCount <= 0f)
					{
						Overlay.AnimationMode = true;
					}
				}
				Thread.Sleep(25);
			}
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x007224C0 File Offset: 0x007206C0
		private void ShowAnimatedArrow(Graphics gfx, Vector2 Location, float Left = 0f, float Top = 0f, string Position = "Top", string Color = "WhiteTransparent")
		{
			if (Position == "Top")
			{
				float num = Location.X + Left;
				float num2 = Location.Y + Overlay.AnimationCount + Top;
				gfx.DrawTriangle(this._brushes[Color], num, num2 + 10f, num - 5f, num2, num + 5f, num2, 8f);
				gfx.DrawLine(this._brushes[Color], num, num2 - 25f, num, num2 - 4f, 8f);
				return;
			}
			if (Position == "Bottom")
			{
				float num3 = Location.X + Left;
				float num4 = Location.Y + Overlay.AnimationCount + Top;
				gfx.DrawTriangle(this._brushes[Color], num3 - 5f, num4, num3 + 5f, num4, num3, num4 - 10f, 8f);
				gfx.DrawLine(this._brushes[Color], num3, num4 + 4f, num3, num4 + 25f, 8f);
				return;
			}
			if (Position == "Left")
			{
				float num5 = Location.X + Overlay.AnimationCount + Left;
				float num6 = Location.Y + Top;
				gfx.DrawTriangle(this._brushes[Color], num5, num6 - 5f, num5, num6 + 5f, num5 + 10f, num6, 8f);
				gfx.DrawLine(this._brushes[Color], num5 - 25f, num6, num5 - 4f, num6, 8f);
			}
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00722658 File Offset: 0x00720858
		private void DrawHoverCircle(Graphics gfx, float X, float Y, int SizeInner, int SizeOuter, string Color, int CrdIndex = -1, Vector3 Crd = default(Vector3))
		{
			Overlay.HoverFound = false;
			gfx.FillCircle(this._brushes[Color], X, Y, (float)SizeInner);
			if (!frmProfileEvent.RecordingEventRoute)
			{
				if (!this.IsHover(X + (float)this._window.X, Y + (float)this._window.Y, SizeInner * 3))
				{
					gfx.DashedCircle(this._brushes[Color], X, Y, (float)SizeOuter, 3f);
				}
				else
				{
					gfx.DashedCircle(this._brushes["Green"], X, Y, (float)SizeOuter, 3f);
					Overlay.HoverFound = true;
					if (Tools.MouseIsPressed("Left"))
					{
						Overlay.MenuClicked = true;
						if (CrdIndex > -1)
						{
							Overlay.MenuCrdIndex = CrdIndex + 1;
							Overlay.MenuCrdIndexAutoSelect = CrdIndex;
						}
						if (Crd != default(Vector3))
						{
							Overlay.MenuCrd = Crd;
						}
						Overlay.MenuX = X;
						Overlay.MenuY = Y;
					}
				}
				if (Overlay.MenuClicked && !Tools.MouseIsPressed("LeftRight"))
				{
					Overlay.MenuClicked = false;
				}
				if (!_globals.IsPremiumProfile)
				{
					if (!_globals.ShowRecordedProfile)
					{
						this.DisplayPathMenu(gfx);
						return;
					}
					this.DisplayRecorderMenu(gfx);
				}
			}
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0072277C File Offset: 0x0072097C
		private void DisplayPathMenu(Graphics gfx)
		{
			if (Overlay.MenuX != 0f && Overlay.MenuY != 0f)
			{
				float menuX = Overlay.MenuX;
				float menuY = Overlay.MenuY;
				float num = 170f;
				float num2 = (float)(55 + Overlay.PathMenu.Count * 20);
				float num3 = 15f;
				gfx.FillRectangle(this._brushes["Black"], menuX, menuY, menuX + num, menuY + num2);
				gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Yellow"], menuX + 15f, menuY + num3, "Waypoint #" + Overlay.MenuCrdIndex.ToString());
				num3 = 25f;
				foreach (string text in Overlay.PathMenu)
				{
					num3 += 20f;
					if (!text.Contains("-"))
					{
						if (!Overlay.IsHover(menuX + (float)this._window.X, menuY + (float)this._window.Y + num3, num, this._fonts["ConsolasMedium"].FontSize))
						{
							gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["White"], menuX + 15f, menuY + num3, text);
						}
						else
						{
							gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Green"], menuX + 15f, menuY + num3, text);
							if (Tools.MouseIsPressed("Left"))
							{
								Overlay.MenuItem = new object[]
								{
									text,
									Overlay.MenuCrdIndex - 1
								};
							}
						}
					}
					else
					{
						gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Grey"], menuX + 15f, menuY + num3, "--------------------");
					}
				}
				this.CloseMenu();
			}
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x007229BC File Offset: 0x00720BBC
		public void DisplayRecorderMenu(Graphics gfx)
		{
			if (Overlay.MenuX != 0f && Overlay.MenuY != 0f)
			{
				float menuX = Overlay.MenuX;
				float menuY = Overlay.MenuY;
				List<string> eventNames = ObjectManager.GetEventNames(Overlay.MenuCrd, true);
				int count = eventNames.Count;
				float num = 170f;
				float num2 = (float)(55 + Overlay.RecorderMenu.Count * 20);
				float num3 = 15f;
				if (count > 0)
				{
					num2 += (float)(eventNames.Count * 20 * 2 + 40);
					num += 100f;
				}
				gfx.FillRectangle(this._brushes["Black"], menuX, menuY, menuX + num, menuY + num2);
				gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Yellow"], menuX + 15f, menuY + num3, "Waypoint #" + Overlay.MenuCrdIndex.ToString());
				num3 += 10f;
				bool flag = false;
				foreach (string text in Overlay.RecorderMenu)
				{
					num3 += 20f;
					if (text.Contains("-"))
					{
						gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Grey"], menuX + 15f, menuY + num3, "--------------------");
						if (!flag)
						{
							flag = true;
							if (count > 0)
							{
								int num4 = 1;
								foreach (string text2 in eventNames)
								{
									num3 += 20f;
									if (Overlay.IsHover(menuX + (float)this._window.X, menuY + (float)this._window.Y + num3, num, this._fonts["ConsolasMedium"].FontSize))
									{
										gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Green"], menuX + 15f, menuY + num3, "Edit: #" + num4.ToString() + " " + text2);
										if (Tools.MouseIsPressed("Left"))
										{
											Overlay.MenuItem = new object[]
											{
												"Edit Event",
												Overlay.MenuCrdIndex - 1,
												Convert.ToInt32(text2.Split(new char[]
												{
													'[',
													']'
												})[1])
											};
										}
									}
									else
									{
										gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["BlueLight"], menuX + 15f, menuY + num3, "Edit: #" + num4.ToString() + " " + text2);
									}
									num4++;
								}
								num3 += 20f;
								gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Grey"], menuX + 15f, menuY + num3, "--------------------");
								num4 = 1;
								foreach (string text3 in eventNames)
								{
									num3 += 20f;
									if (!Overlay.IsHover(menuX + (float)this._window.X, menuY + (float)this._window.Y + num3, num, this._fonts["ConsolasMedium"].FontSize))
									{
										gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["RedLight"], menuX + 15f, menuY + num3, "Delete: #" + num4.ToString() + " " + text3);
									}
									else
									{
										gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Red"], menuX + 15f, menuY + num3, "Delete: #" + num4.ToString() + " " + text3);
										if (Tools.MouseIsPressed("Left"))
										{
											Overlay.MenuItem = new object[]
											{
												"Delete Event",
												Overlay.MenuCrdIndex - 1,
												Convert.ToInt32(text3.Split(new char[]
												{
													'[',
													']'
												})[1])
											};
										}
									}
									num4++;
								}
								num3 += 20f;
								gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Grey"], menuX + 15f, menuY + num3, "--------------------");
							}
						}
					}
					else if (!Overlay.IsHover(menuX + (float)this._window.X, menuY + (float)this._window.Y + num3, num, this._fonts["ConsolasMedium"].FontSize))
					{
						gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["White"], menuX + 15f, menuY + num3, text);
					}
					else
					{
						gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Green"], menuX + 15f, menuY + num3, text);
						if (Tools.MouseIsPressed("Left"))
						{
							Overlay.MenuItem = new object[]
							{
								text,
								Overlay.MenuCrdIndex - 1
							};
						}
					}
				}
				this.CloseMenu();
			}
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00722FDC File Offset: 0x007211DC
		private void DrawHoverClimbSpotAntenna(Graphics gfx, float X, float Y, int SizeInner, int SizeOuter, string Color, int CrdIndex = -1, Vector3 Crd = default(Vector3))
		{
			gfx.FillCircle(this._brushes[Color], X, Y + 3f - 15f, 5f);
			gfx.DrawLine(this._brushes[Color], X, Y + 3f - 18f, X, Y + 15f, 2f);
			gfx.DrawEllipse(this._brushes[Color], X, Y + 3f - 4f, 15f, 2f, 1f);
			gfx.DrawEllipse(this._brushes[Color], X, Y + 3f + 3f, 10f, 2f, 1f);
			this.DrawHoverClimbSpot(gfx, X, Y, SizeInner, SizeOuter, Color, CrdIndex, Crd);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x007230B0 File Offset: 0x007212B0
		private void DrawHoverClimbSpotCircle(Graphics gfx, float X, float Y, int SizeInner, int SizeOuter, string Color, int CrdIndex = -1, Vector3 Crd = default(Vector3))
		{
			gfx.FillCircle(this._brushes[Color], X, Y, (float)SizeInner);
			this.DrawHoverClimbSpot(gfx, X, Y, SizeInner, SizeOuter, Color, CrdIndex, Crd);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x007230E8 File Offset: 0x007212E8
		private void DrawHoverClimbSpot(Graphics gfx, float X, float Y, int SizeInner, int SizeOuter, string Color, int CrdIndex = -1, Vector3 Crd = default(Vector3))
		{
			Overlay.HoverFoundClimbSpot = false;
			if (_globals.ShowRecordedProfile && !frmProfileEvent.RecordingEventRoute)
			{
				if (!this.IsHover(X + (float)this._window.X, Y + (float)this._window.Y, SizeInner * 3))
				{
					gfx.DashedCircle(this._brushes[Color], X, Y, (float)SizeOuter, 3f);
				}
				else
				{
					gfx.DashedCircle(this._brushes["Green"], X, Y, (float)SizeOuter, 3f);
					Overlay.HoverFoundClimbSpot = true;
					if (Tools.MouseIsPressed("Left"))
					{
						Overlay.MenuClickedClimbSpot = true;
						if (CrdIndex > -1)
						{
							Overlay.MenuCrdIndexClimbSpot = CrdIndex + 1;
							Overlay.MenuCrdIndexAutoSelectClimbSpot = CrdIndex;
						}
						if (Crd != default(Vector3))
						{
							Overlay.MenuCrdClimbSpot = Crd;
						}
						Overlay.MenuXClimbSpot = X;
						Overlay.MenuYClimbSpot = Y;
					}
				}
				if (Overlay.MenuClickedClimbSpot && !Tools.MouseIsPressed("LeftRight"))
				{
					Overlay.MenuClickedClimbSpot = false;
				}
				this.DisplayClimbSpotMenu(gfx);
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x007231E8 File Offset: 0x007213E8
		private void DisplayClimbSpotMenu(Graphics gfx)
		{
			if (Overlay.MenuXClimbSpot != 0f && Overlay.MenuYClimbSpot != 0f)
			{
				float menuXClimbSpot = Overlay.MenuXClimbSpot;
				float menuYClimbSpot = Overlay.MenuYClimbSpot;
				float num = 170f;
				float num2 = (float)(55 + Overlay.ClimbSpotMenu.Count * 20);
				float num3 = 15f;
				gfx.FillRectangle(this._brushes["Black"], menuXClimbSpot, menuYClimbSpot, menuXClimbSpot + num, menuYClimbSpot + num2);
				gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Yellow"], menuXClimbSpot + 15f, menuYClimbSpot + num3, "Climb Spot #" + Overlay.MenuCrdIndex.ToString());
				num3 = 25f;
				foreach (string text in Overlay.ClimbSpotMenu)
				{
					num3 += 20f;
					if (!text.Contains("-"))
					{
						if (Overlay.IsHover(menuXClimbSpot + (float)this._window.X, menuYClimbSpot + (float)this._window.Y + num3, num, this._fonts["ConsolasMedium"].FontSize))
						{
							gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Green"], menuXClimbSpot + 15f, menuYClimbSpot + num3, text);
							if (Tools.MouseIsPressed("Left"))
							{
								Overlay.MenuItem = new object[]
								{
									text,
									Overlay.MenuCrdIndexClimbSpot - 1
								};
							}
						}
						else
						{
							gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["White"], menuXClimbSpot + 15f, menuYClimbSpot + num3, text);
						}
					}
					else
					{
						gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes["Grey"], menuXClimbSpot + 15f, menuYClimbSpot + num3, "--------------------");
					}
				}
				this.CloseMenu();
			}
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00723428 File Offset: 0x00721628
		private void CloseMenu()
		{
			if (Tools.MouseIsPressed("LeftRight"))
			{
				if (!Overlay.MenuClicked && !Overlay.HoverFound)
				{
					Overlay.MenuX = 0f;
					Overlay.MenuY = 0f;
				}
				if (!Overlay.MenuClickedClimbSpot && !Overlay.HoverFoundClimbSpot)
				{
					Overlay.MenuXClimbSpot = 0f;
					Overlay.MenuYClimbSpot = 0f;
				}
			}
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00723488 File Offset: 0x00721688
		private void ShowConsole(Graphics gfx)
		{
			int num = Settings.OverlayMenuConsoleX - this.ConsoleSize[0] / 2;
			int num2 = this._window.Y + Settings.OverlayMenuConsoleY;
			int num3 = num + this.ConsoleSize[0];
			int num4 = num2 + this.ConsoleSize[1];
			if (Settings.OverlayMenuConsoleX == 0 && Settings.OverlayMenuConsoleY == 0)
			{
				num = this._window.Width / 2 - 200;
				num2 = this._window.Y + 50;
				num3 = num + 400;
				num4 = num2 + 120;
			}
			gfx.FillRectangle(this._brushes["BlackTransparentFull"], (float)num, (float)(num2 + this.ConsoleSize[1] + 5), (float)num3, (float)(num2 + this.ConsoleSize[1] + 5 + 20));
			gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["Grey"], (float)(num + 15), (float)(num2 + this.ConsoleSize[1] + 9), Overlay.ConsoleInfo);
			float num5 = 15f;
			if (!Overlay.ConsoleClicked)
			{
				if (this.IsHover(num + this._window.X, num2 + this._window.Y, num3 + this._window.X, num4 + this._window.Y))
				{
					gfx.FillRectangle(this._brushes["BlackTransparent"], (float)num, (float)num2, (float)num3, (float)num4);
					if (Tools.MouseIsPressed("Right") && !Overlay.ConsoleDrag)
					{
						Window.Enable(_globals.processHandle, false);
						Overlay.ConsoleClicked = true;
						Overlay.ConsoleDrag = true;
					}
				}
				else
				{
					gfx.FillRectangle(this._brushes["BlackTransparentFull"], (float)num, (float)num2, (float)num3, (float)num4);
				}
				foreach (string[] array in Tools.GetConsoleLog(6))
				{
					gfx.DrawText(this._fonts["ConsolasMedium"], this._brushes[array[1]], (float)(num + 15), (float)num2 + num5, array[0]);
					num5 += 15f;
				}
			}
			if (Overlay.ConsoleClicked && !Tools.MouseIsPressed("Right"))
			{
				Overlay.ConsoleClicked = false;
			}
			if (!Overlay.ConsoleClicked && Tools.MouseIsPressed("Right") && Overlay.ConsoleDrag)
			{
				Overlay.ConsoleClicked = true;
				Overlay.ConsoleDrag = false;
				Window.Enable(_globals.processHandle, true);
			}
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00723700 File Offset: 0x00721900
		private void ShowStartStop(Graphics gfx)
		{
			int num = Settings.OverlayMenuStartStopX - this.StartStopSize[0] / 2;
			int num2 = this._window.Y + Settings.OverlayMenuStartStopY;
			int num3 = num + this.StartStopSize[0];
			int num4 = num2 + this.StartStopSize[1];
			if (Settings.OverlayMenuStartStopX == 0 && Settings.OverlayMenuStartStopY == 0)
			{
				num = this._window.Width / 2 - this.StartStopSize[0] / 2;
				num2 = this._window.Y + this._window.Height - 250;
				num3 = num + this.StartStopSize[0];
				num4 = num2 + this.StartStopSize[1];
			}
			gfx.FillRectangle(this._brushes["BlackTransparent"], (float)num, (float)(num2 - 20), (float)num3, (float)num2);
			gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["White"], (float)(num + 5), (float)(num2 - 15), "Player");
			gfx.FillRectangle(this._brushes["BlackTransparentFull"], (float)num, (float)num2, (float)num3, (float)num4);
			if (!Overlay.StartStopClicked)
			{
				if (this.IsHover(num + this._window.X, num2 + this._window.Y - 20, num3 + this._window.X, num2 + this._window.Y) && Tools.MouseIsPressed("Right") && !Overlay.StartStopDrag)
				{
					Window.Enable(_globals.processHandle, false);
					Overlay.StartStopClicked = true;
					Overlay.StartStopDrag = true;
				}
				num3 = num;
				if (!_globals.Start && !_globals.AutoStart)
				{
					num3 += 60;
					gfx.FillRectangle(this._brushes["Black"], (float)num, (float)num2, (float)num3, (float)num4);
					if (this.IsHover(num + this._window.X, num2 + this._window.Y, num3 + this._window.X, num4 + this._window.Y))
					{
						if (Tools.MouseIsPressed("Left"))
						{
							Overlay.StartStopClicked = true;
							Overlay.MenuItem = new object[]
							{
								"Start"
							};
						}
						gfx.DrawTriangle(this._brushes["Green"], (float)((num + num3) / 2 - 5), (float)((num2 + num4) / 2 - 3), (float)((num + num3) / 2 - 5), (float)((num2 + num4) / 2 + 3), (float)((num + num3) / 2), (float)((num2 + num4) / 2), 8f);
					}
					else
					{
						gfx.DrawTriangle(this._brushes["White"], (float)((num + num3) / 2 - 5), (float)((num2 + num4) / 2 - 3), (float)((num + num3) / 2 - 5), (float)((num2 + num4) / 2 + 3), (float)((num + num3) / 2), (float)((num2 + num4) / 2), 8f);
					}
				}
				else
				{
					num3 += 60;
					if (!this.IsHover(num + this._window.X, num2 + this._window.Y, num3 + this._window.X, num4 + this._window.Y))
					{
						gfx.FillRectangle(this._brushes["Red"], (float)num, (float)num2, (float)num3, (float)num4);
					}
					else
					{
						if (Tools.MouseIsPressed("Left"))
						{
							Overlay.StartStopClicked = true;
							Overlay.MenuItem = new object[]
							{
								"Stop"
							};
						}
						gfx.FillRectangle(this._brushes["Red"], (float)num, (float)num2, (float)num3, (float)num4);
					}
					gfx.FillRectangle(this._brushes["White"], (float)((num + num3) / 2 - 8), (float)((num2 + num4) / 2 - 8), (float)((num + num3) / 2 + 8), (float)((num2 + num4) / 2 + 8));
				}
			}
			if (Overlay.StartStopClicked && !Tools.MouseIsPressed("LeftRight"))
			{
				Overlay.StartStopClicked = false;
			}
			if (!Overlay.StartStopClicked && Tools.MouseIsPressed("Right") && Overlay.StartStopDrag)
			{
				Overlay.StartStopClicked = true;
				Overlay.StartStopDrag = false;
				Window.Enable(_globals.processHandle, true);
			}
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00723AE0 File Offset: 0x00721CE0
		private void ShowRecorder(Graphics gfx)
		{
			if (_globals.ShowClimbSpots)
			{
				this.RecorderSize[0] = 362;
			}
			else
			{
				this.RecorderSize[0] = 162;
			}
			int num = Settings.OverlayMenuRecorderX - this.RecorderSize[0] / 2;
			int num2 = this._window.Y + Settings.OverlayMenuRecorderY;
			int num3 = num + this.RecorderSize[0];
			int num4 = num2 + this.RecorderSize[1];
			if (Settings.OverlayMenuRecorderX == 0 && Settings.OverlayMenuRecorderY == 0)
			{
				num = this._window.Width / 2 - this.RecorderSize[0] / 2;
				num2 = this._window.Y + this._window.Height - 250;
				num3 = num + this.RecorderSize[0];
				num4 = num2 + this.RecorderSize[1];
			}
			gfx.FillRectangle(this._brushes["BlackTransparent"], (float)num, (float)(num2 - 20), (float)num3, (float)num2);
			gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["White"], (float)(num + 5), (float)(num2 - 15), "Recorder");
			gfx.FillRectangle(this._brushes["BlackTransparentFull"], (float)num, (float)(num2 + this.RecorderSize[1] + 5), (float)num3, (float)(num2 + this.RecorderSize[1] + 5 + 20));
			gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["Grey"], (float)(num + 5), (float)(num2 + this.RecorderSize[1] + 9), Overlay.RecorderInfo);
			gfx.FillRectangle(this._brushes["BlackTransparentFull"], (float)num, (float)num2, (float)num3, (float)num4);
			if (!Overlay.RecorderClicked)
			{
				if (this.IsHover(num + this._window.X, num2 + this._window.Y - 20, num3 + this._window.X, num2 + this._window.Y) && Tools.MouseIsPressed("Right") && !Overlay.RecorderDrag)
				{
					Window.Enable(_globals.processHandle, false);
					Overlay.RecorderClicked = true;
					Overlay.RecorderDrag = true;
				}
				num3 = num;
				if (!Overlay.IsRecording && !_globals.Record)
				{
					num3 += 60;
					gfx.FillRectangle(this._brushes["Black"], (float)num, (float)num2, (float)num3, (float)num4);
					if (!this.IsHover(num + this._window.X, num2 + this._window.Y, num3 + this._window.X, num4 + this._window.Y))
					{
						gfx.FillCircle(this._brushes["Green"], (float)((num + num3) / 2), (float)((num2 + num4) / 2), 8f);
					}
					else
					{
						if (Tools.MouseIsPressed("Left"))
						{
							Overlay.RecorderClicked = true;
							Overlay.IsRecording = true;
							Overlay.MenuItem = new object[]
							{
								"Record Start"
							};
						}
						gfx.FillCircle(this._brushes["Red"], (float)((num + num3) / 2), (float)((num2 + num4) / 2), 8f);
					}
					num += 62;
					num3 += 100;
					gfx.FillRectangle(this._brushes["Black"], (float)num, (float)num2, (float)num3, (float)num4);
					gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["Grey"], (float)((num + num3) / 2 - 28), (float)((num2 + num4) / 2 - 5), "Add Single");
				}
				else
				{
					num3 += 60;
					if (!this.IsHover(num + this._window.X, num2 + this._window.Y, num3 + this._window.X, num4 + this._window.Y))
					{
						gfx.FillRectangle(this._brushes["Red"], (float)num, (float)num2, (float)num3, (float)num4);
					}
					else
					{
						if (Tools.MouseIsPressed("Left"))
						{
							Overlay.RecorderClicked = true;
							Overlay.IsRecording = false;
							Overlay.MenuItem = new object[]
							{
								"Record Stop"
							};
						}
						gfx.FillRectangle(this._brushes["Red"], (float)num, (float)num2, (float)num3, (float)num4);
					}
					gfx.FillRectangle(this._brushes["White"], (float)((num + num3) / 2 - 8), (float)((num2 + num4) / 2 - 8), (float)((num + num3) / 2 + 8), (float)((num2 + num4) / 2 + 8));
					num += 62;
					num3 += 100;
					gfx.FillRectangle(this._brushes["Black"], (float)num, (float)num2, (float)num3, (float)num4);
					if (!this.IsHover(num + this._window.X, num2 + this._window.Y, num3 + this._window.X, num4 + this._window.Y))
					{
						gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["White"], (float)((num + num3) / 2 - 28), (float)((num2 + num4) / 2 - 5), "Add Single");
					}
					else
					{
						if (Tools.MouseIsPressed("Left"))
						{
							Overlay.RecorderClicked = true;
							Overlay.IsRecording = true;
							Overlay.MenuItem = new object[]
							{
								"Add Single"
							};
						}
						gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["Green"], (float)((num + num3) / 2 - 28), (float)((num2 + num4) / 2 - 5), "Add Single");
					}
				}
				if (_globals.ShowClimbSpots)
				{
					num += 100;
					num3 += 100;
					gfx.FillRectangle(this._brushes["Black"], (float)num, (float)num2, (float)num3, (float)num4);
					if (this.IsHover(num + this._window.X, num2 + this._window.Y, num3 + this._window.X, num4 + this._window.Y))
					{
						if (Tools.MouseIsPressed("Left"))
						{
							Overlay.RecorderClicked = true;
							Overlay.MenuItem = new object[]
							{
								"Add Climb Spot"
							};
						}
						gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["Green"], (float)((num + num3) / 2 - 38), (float)((num2 + num4) / 2 - 5), "Add Climb Spot");
					}
					else
					{
						gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["White"], (float)((num + num3) / 2 - 38), (float)((num2 + num4) / 2 - 5), "Add Climb Spot");
					}
					num += 100;
					num3 += 100;
					gfx.FillRectangle(this._brushes["Black"], (float)num, (float)num2, (float)num3, (float)num4);
					if (!this.IsHover(num + this._window.X, num2 + this._window.Y, num3 + this._window.X, num4 + this._window.Y))
					{
						gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["White"], (float)((num + num3) / 2 - 38), (float)((num2 + num4) / 2 - 5), "Add Check Spot");
					}
					else
					{
						if (Tools.MouseIsPressed("Left"))
						{
							Overlay.RecorderClicked = true;
							Overlay.MenuItem = new object[]
							{
								"Add Check Spot"
							};
						}
						gfx.DrawText(this._fonts["ConsolasSmall"], this._brushes["Green"], (float)((num + num3) / 2 - 38), (float)((num2 + num4) / 2 - 5), "Add Check Spot");
					}
				}
			}
			if (Overlay.RecorderClicked && !Tools.MouseIsPressed("LeftRight"))
			{
				Overlay.RecorderClicked = false;
			}
			if (!Overlay.RecorderClicked && Tools.MouseIsPressed("Right") && Overlay.RecorderDrag)
			{
				Overlay.RecorderClicked = true;
				Overlay.RecorderDrag = false;
				Window.Enable(_globals.processHandle, true);
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0072429C File Offset: 0x0072249C
		private bool IsHover(int Left, int Top, int Width, int Height)
		{
			Point position = Cursor.Position;
			return position.X > Left && position.X < Width && position.Y > Top && position.Y < Height;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x007242DC File Offset: 0x007224DC
		private bool IsHover(float X, float Y, int Size)
		{
			Point position = Cursor.Position;
			Size /= 2;
			return (float)position.X > X - (float)Size && (float)position.X < X + (float)Size && (float)position.Y > Y - (float)Size && (float)position.Y < Y + (float)Size;
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00724330 File Offset: 0x00722530
		private static bool IsHover(float X, float Y, float Width, float Height)
		{
			Point position = Cursor.Position;
			return (float)position.X > X && (float)position.X < X + Width && (float)position.Y > Y && (float)position.Y < Y + Height;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00724378 File Offset: 0x00722578
		public void Run()
		{
			if (this._window == null)
			{
				return;
			}
			Overlay.Runs = true;
			this._window.Create();
			_globals.OverlayHandle = this._window.Handle;
			this._window.Join();
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x007243BC File Offset: 0x007225BC
		public void Close()
		{
			Overlay.Stop = false;
			Overlay.Runs = false;
			if (this._window == null)
			{
				return;
			}
			this._window.Hide();
			this._window.Dispose();
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x007243F4 File Offset: 0x007225F4
		~Overlay()
		{
			this.Dispose(false);
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00724424 File Offset: 0x00722624
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
				this.disposedValue = true;
				if (this._window != null)
				{
					this._window.Dispose();
				}
			}
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00724454 File Offset: 0x00722654
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00724470 File Offset: 0x00722670
		// Note: this type is marked as 'beforefieldinit'.
		static Overlay()
		{
			Dictionary<string, object[]> dictionary = new Dictionary<string, object[]>();
			dictionary["Global"] = null;
			dictionary["Run"] = null;
			dictionary["Record"] = null;
			dictionary["Mark"] = null;
			Overlay.DisplayMode = dictionary;
			Dictionary<string, bool> dictionary2 = new Dictionary<string, bool>();
			dictionary2["Global"] = false;
			dictionary2["Run"] = false;
			dictionary2["Record"] = false;
			dictionary2["Mark"] = false;
			Overlay.DisplayModeUpdate = dictionary2;
			Overlay.AnimationCount = 10f;
			Overlay.AnimationMode = false;
			Overlay.PathMenu = new List<string>
			{
				"Edit Profile..."
			};
			Overlay.RecorderMenu = new List<string>
			{
				"Create Event...",
				"Connect Profile...",
				"Add Waypoint after",
				"-",
				"Delete Waypoint"
			};
			Overlay.RecorderMenuEvents = new Dictionary<string, float[]>();
			Overlay.MenuX = 0f;
			Overlay.MenuY = 0f;
			Overlay.HoverFound = false;
			Overlay.MenuClicked = false;
			Overlay.MenuItem = null;
			Overlay.MenuCrdIndex = -1;
			Overlay.MenuCrdIndexAutoSelect = -1;
			Overlay.MenuCrd = default(Vector3);
			Overlay.ClimbSpotMenu = new List<string>
			{
				"Add Climb Spot after",
				"Add Check Spot after",
				"-",
				"Delete Climb Spot"
			};
			Overlay.MenuXClimbSpot = 0f;
			Overlay.MenuYClimbSpot = 0f;
			Overlay.HoverFoundClimbSpot = false;
			Overlay.MenuClickedClimbSpot = false;
			Overlay.MenuCrdIndexClimbSpot = -1;
			Overlay.MenuCrdIndexAutoSelectClimbSpot = -1;
			Overlay.MenuCrdClimbSpot = default(Vector3);
			Overlay.ConsoleDrag = false;
			Overlay.ConsoleClicked = false;
			Overlay.ConsoleInfo = "";
			Overlay.StartStopClicked = false;
			Overlay.StartStopDrag = false;
			Overlay.IsRecording = false;
			Overlay.RecorderClicked = false;
			Overlay.RecorderDrag = false;
			Overlay.RecorderInfo = "";
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00724700 File Offset: 0x00722900
		[CompilerGenerated]
		private void method_0(Vector3 Waypoint, Vector2 WaypointW2S, ref Overlay.<>c__DisplayClass17_0 <>c__DisplayClass17_0_0)
		{
			if (_globals.Events.Count == 0)
			{
				return;
			}
			int num = 1;
			int num2 = 0;
			string text = "";
			foreach (Events events in _globals.Events)
			{
				if (!(events.Vector3 != Waypoint))
				{
					num2 += 30;
					if (num != 1)
					{
						text = string.Concat(new string[]
						{
							text,
							"\r\n",
							num.ToString(),
							". ",
							events.Name
						});
					}
					else
					{
						text = string.Concat(new string[]
						{
							text,
							" # EVENT(S) #\r\n",
							num.ToString(),
							". ",
							events.Name
						});
					}
					num++;
				}
			}
			if (text.Length == 0)
			{
				return;
			}
			<>c__DisplayClass17_0_0.gfx.DrawTextWithBackground(this._fonts["ConsolasSmall"], this._brushes["White"], this._brushes["Black"], WaypointW2S.X + 18f, WaypointW2S.Y - (float)num2, text);
			<>c__DisplayClass17_0_0.gfx.DrawImage(this._images["JackHeadBlue"], WaypointW2S.X + 4f, WaypointW2S.Y - (float)num2 - 15f, 1f);
		}

		// Token: 0x04000B48 RID: 2888
		public readonly GraphicsWindow _window;

		// Token: 0x04000B49 RID: 2889
		private readonly bool HasHerbalism;

		// Token: 0x04000B4A RID: 2890
		private readonly bool HasMining;

		// Token: 0x04000B4B RID: 2891
		private readonly bool HasSkinning;

		// Token: 0x04000B4C RID: 2892
		public static bool Stop = false;

		// Token: 0x04000B4D RID: 2893
		public static bool Runs = false;

		// Token: 0x04000B4E RID: 2894
		public static bool AnimationRuns = false;

		// Token: 0x04000B4F RID: 2895
		public HashSet<int> HashListMineableMobs = new HashSet<int>(_globals.List_MiningMobs);

		// Token: 0x04000B50 RID: 2896
		public HashSet<int> HashListHerbableMobs = new HashSet<int>(_globals.List_HerbalismMobs);

		// Token: 0x04000B51 RID: 2897
		private readonly Dictionary<string, SolidBrush> _brushes;

		// Token: 0x04000B52 RID: 2898
		private readonly Dictionary<string, Font> _fonts;

		// Token: 0x04000B53 RID: 2899
		private readonly Dictionary<string, Image> _images;

		// Token: 0x04000B54 RID: 2900
		public static List<Vector3> MeshPath = new List<Vector3>();

		// Token: 0x04000B55 RID: 2901
		public static bool ShowMeshPath = false;

		// Token: 0x04000B56 RID: 2902
		public static List<Vector3> TestPath = new List<Vector3>();

		// Token: 0x04000B57 RID: 2903
		public static bool ShowRadius = false;

		// Token: 0x04000B58 RID: 2904
		public static Vector3 RadiusHover = Vector3.Zero;

		// Token: 0x04000B59 RID: 2905
		public static List<StuckPaths> RadiusClickedSelection = new List<StuckPaths>();

		// Token: 0x04000B5A RID: 2906
		public static double RadiusAngle = 0.6;

		// Token: 0x04000B5B RID: 2907
		public static int RadiusRadius = 5;

		// Token: 0x04000B5C RID: 2908
		public static int RadiusRotation = 0;

		// Token: 0x04000B5D RID: 2909
		public static int RadiusDivision = 2;

		// Token: 0x04000B5E RID: 2910
		public static bool ShowRadiusAroundOwnLocation = false;

		// Token: 0x04000B5F RID: 2911
		public static bool ShowSavedRadius = false;

		// Token: 0x04000B60 RID: 2912
		public static Vector3 SavedRadiusLocation = Vector3.Zero;

		// Token: 0x04000B61 RID: 2913
		public static string SavedRadiusName = "";

		// Token: 0x04000B62 RID: 2914
		public static double SavedRadiusAngle = 0.0;

		// Token: 0x04000B63 RID: 2915
		public static int SavedRadiusRadius = 0;

		// Token: 0x04000B64 RID: 2916
		public static int SavedRadiusRotation = 0;

		// Token: 0x04000B65 RID: 2917
		public static int SavedRadiusDivision = 0;

		// Token: 0x04000B66 RID: 2918
		public static Dictionary<Vector3, string> GoalList = new Dictionary<Vector3, string>();

		// Token: 0x04000B67 RID: 2919
		public static bool ShowGoalList = false;

		// Token: 0x04000B6C RID: 2924
		private static List<string> PathMenu;

		// Token: 0x04000B6D RID: 2925
		private static List<string> RecorderMenu;

		// Token: 0x04000B6E RID: 2926
		private static Dictionary<string, float[]> RecorderMenuEvents;

		// Token: 0x04000B6F RID: 2927
		private static float MenuX;

		// Token: 0x04000B70 RID: 2928
		private static float MenuY;

		// Token: 0x04000B71 RID: 2929
		private static bool HoverFound;

		// Token: 0x04000B72 RID: 2930
		private static bool MenuClicked;

		// Token: 0x04000B73 RID: 2931
		public static object[] MenuItem;

		// Token: 0x04000B74 RID: 2932
		private static int MenuCrdIndex;

		// Token: 0x04000B75 RID: 2933
		public static int MenuCrdIndexAutoSelect;

		// Token: 0x04000B76 RID: 2934
		private static Vector3 MenuCrd;

		// Token: 0x04000B77 RID: 2935
		private static List<string> ClimbSpotMenu;

		// Token: 0x04000B78 RID: 2936
		private static float MenuXClimbSpot;

		// Token: 0x04000B79 RID: 2937
		private static float MenuYClimbSpot;

		// Token: 0x04000B7A RID: 2938
		private static bool HoverFoundClimbSpot;

		// Token: 0x04000B7B RID: 2939
		private static bool MenuClickedClimbSpot;

		// Token: 0x04000B7C RID: 2940
		private static int MenuCrdIndexClimbSpot;

		// Token: 0x04000B7D RID: 2941
		public static int MenuCrdIndexAutoSelectClimbSpot;

		// Token: 0x04000B7E RID: 2942
		private static Vector3 MenuCrdClimbSpot;

		// Token: 0x04000B7F RID: 2943
		private int[] ConsoleSize = new int[]
		{
			400,
			120
		};

		// Token: 0x04000B80 RID: 2944
		public static bool ConsoleDrag;

		// Token: 0x04000B81 RID: 2945
		public static bool ConsoleClicked;

		// Token: 0x04000B82 RID: 2946
		private static string ConsoleInfo;

		// Token: 0x04000B83 RID: 2947
		private int[] StartStopSize = new int[]
		{
			60,
			40
		};

		// Token: 0x04000B84 RID: 2948
		public static bool StartStopClicked;

		// Token: 0x04000B85 RID: 2949
		public static bool StartStopDrag;

		// Token: 0x04000B86 RID: 2950
		private int[] RecorderSize = new int[]
		{
			162,
			40
		};

		// Token: 0x04000B87 RID: 2951
		public static bool IsRecording;

		// Token: 0x04000B88 RID: 2952
		public static bool RecorderClicked;

		// Token: 0x04000B89 RID: 2953
		public static bool RecorderDrag;

		// Token: 0x04000B8A RID: 2954
		private static string RecorderInfo;

		// Token: 0x04000B8B RID: 2955
		private bool disposedValue;
	}
}
