async function sendRequest(url, body = null, method = 'GET') {
    const response = await fetch(url, {
        method: method,
        headers: {
            'Content-Type': 'application/x-www-form-urlencoded;charset=UTF-8'
        },
        body: body
    });
     
    return await response.json();
}

export default sendRequest;