# Dokumentasi API

## Register

Endpoint untuk mendaftar pengguna baru.

### URL

### Request

| Property  | Type   | Required | Description             |
| --------- | ------ | -------- | ----------------------- |
| firstname | string | Yes      | Nama depan pengguna.    |
| lastname  | string | Yes      | Nama belakang pengguna. |
| email     | string | Yes      | Alamat email pengguna.  |
| password  | string | Yes      | Kata sandi pengguna.    |

### Contoh Request

```js
POST {{host}}/auth/register
```

```json
POST /register
{
    "firstname": "John",
    "lastname": "Doe",
    "email": "john.doe@example.com",
    "password": "secretpassword"
}
```

### Response Register

```js
200 OK
```

```json
{
    "id": 1,
    "firstname": "John",
    "lastname": "Doe",
    "email": "john.doe@example.com",
    "token":"token"
}
```

### POST /login

```json
POST /login
{
    "email": "john.doe@example.com",
    "password": "secretpassword"
}

```

```js
200 OK
```

### Response

```json
{
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c"
}

```
