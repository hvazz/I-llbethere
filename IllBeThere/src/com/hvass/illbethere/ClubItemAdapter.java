//package com.hvass.illbethere;
//
//import java.util.ArrayList;
//
//import android.content.Context;
//import android.view.LayoutInflater;
//import android.view.View;
//import android.view.ViewGroup;
//import android.widget.ArrayAdapter;
//import android.widget.TextView;
//
//public class ClubItemAdapter extends ArrayAdapter<Club> {
//	private ArrayList<Club> clubs;
//	private Context con;
//	
//	public ClubItemAdapter(Context context, int textViewResourceId, ArrayList<Club> clubs) {
//		super(context, textViewResourceId, clubs);
//		this.con = context;
//		this.clubs = clubs;
//	}
//
//	@Override
//	public View getView(int position, View convertView, ViewGroup parent) {
//		View v = convertView;
//		if (v == null) {
//			LayoutInflater vi = (LayoutInflater)con.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
//			v = vi.inflate(R.layout.listitem, null);
//		}
//
//		Club club = clubs.get(position);
//		if (club != null) {
//			TextView clubName = (TextView) v.findViewById(R.id.clubName);
//			TextView clubDesc = (TextView) v.findViewById(R.id.clubDesc);
//
//			if (clubName != null) {
//				clubName.setText(club.name);
//			}
//
//			if(clubDesc != null) {
//				clubDesc.setText("Email: " + club.description);
//			}
//		}
//		return v;
//	}
//}
