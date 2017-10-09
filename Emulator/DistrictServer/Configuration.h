#pragma once

class Configuration
{
private:
	char* ip;
	char* port;
	int districtType;
	int districtId;

public:
	Configuration(char* file);
	char* GetWorldIP();
	char* GetWorldPort();
	int GetDistrictType();
	int GetDistrictID();
};