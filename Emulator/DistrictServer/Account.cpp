#include "stdafx.h"
#include "Account.h"

Account::Account(int id, char* encryptionKey)
{
	this->id = id;
	this->encryptionKey = new char[16];
	strcpy(this->encryptionKey, encryptionKey);
}

void Account::SetId(int id)
{
	this->id = id;
}

int Account::GetId()
{
	return this->id;
}

void Account::SetEncryptionKey(char* encryptionKey)
{
	this->encryptionKey = new char[16];
	strcpy(this->encryptionKey, encryptionKey);
}

char* Account::GetEncryptionKey()
{
	return this->encryptionKey;
}