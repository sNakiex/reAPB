#include "stdafx.h"
#include "Configuration.h"

Configuration::Configuration(char* file)
{
	ifstream in(file);
	char str[255];
	int line = 0;
	ip = new char[16];
	port = new char[4];
	districtId = 0;
	districtType = 0;

	if (!in)
	{
		cout << "Cannot open config file.\n";
		return;
	}

	while (in) 
	{
		in.getline(str, 255);
		if (in)
		{
			if (line == 0) strcpy(ip, str);
			else if (line == 1) strcpy(port, str);
			else if (line == 2)
			{
				//TODO: support for other districts when their IDs are found
				if (strcmp(str, "Social") == 0) districtType = 1;
				else if (strcmp(str, "Financial") == 0) districtType = 2;
				else if (strcmp(str, "Tutorial") == 0) districtType = 14;
				else if (strcmp(str, "Waterfront") == 0) districtType = 21;
				else districtType = 1;
			}
			else if (line == 3) districtId = atoi(str);
			line++;
		}
	}
	in.close();
}

char* Configuration::GetWorldIP()
{
	return this->ip;
}

char* Configuration::GetWorldPort()
{
	return this->port;
}

int Configuration::GetDistrictType()
{
	return this->districtType;
}

int Configuration::GetDistrictID()
{
	return this->districtId;
}