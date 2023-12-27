using Godot;
using System;

public partial class WQueen : ChessPiece
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		base._Ready();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		base._Process(delta);
	}
	public override bool isValidMove(Vector2 tempPos)
    {
		Vector2I tempTile = tileMap.FromGlobalPosToTile((Vector2I)tempPos);
		int xOffset = tempTile.X - prevTile.X;
		int yOffset = tempTile.Y - prevTile.Y;
	
		if(tempTile.X == prevTile.X || tempTile.Y == prevTile.Y)
		{
			return true;
		}
		
	
		if(yOffset == xOffset || yOffset - xOffset == 0 || yOffset + xOffset == 0)
		{
			return true;
		}
		
		return false;
	}
}

